﻿using AutoMapper;
using Microsoft.Ajax.Utilities;
using Stagio.DataLayer;
using Stagio.Domain.Application;
using Stagio.Domain.Entities;
using Stagio.Utilities.Encryption;
using Stagio.Web.Module;
using Stagio.Web.Module.Strings.Controller;
using Stagio.Web.Module.Strings.Email;
using Stagio.Web.Module.Strings.Notification;
using Stagio.Web.Module.Strings.Shared;
using Stagio.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stagio.Web.Controllers
{
    public partial class StudentController : Controller
    {
        private readonly IEntityRepository<Student> _studentRepository;
        private readonly IEntityRepository<Stage> _stageRepository;
        private readonly IHttpContextService _httpContextService;
        private readonly IEntityRepository<Stagio.Domain.Entities.Apply> _applyRepository;
        private readonly IMailler _mailler;
        private readonly IAccountService _accountService;
        private readonly INotificationService _notificationService;

        public StudentController(IEntityRepository<Student> studentRepository, IEntityRepository<Stage> stageRepository, IEntityRepository<Stagio.Domain.Entities.Apply> applyRepository, IHttpContextService httpContextService, IMailler mailler, IAccountService accountService, INotificationService notificationService)
        {
            _studentRepository = studentRepository;
            _stageRepository = stageRepository;
            _httpContextService = httpContextService;
            _applyRepository = applyRepository;
            _mailler = mailler;
            _accountService = accountService;
            _notificationService = notificationService;
        }

        [Authorize(Roles = RoleName.Student)]
        public virtual ActionResult Index()
        {
            var notifications = _notificationService.GetDashboardNotificationForUser(_httpContextService.GetUserId());

            var notificationsViewModels = Mapper.Map<IEnumerable<ViewModels.Notification.Notification>>(notifications).ToList();

            return View(notificationsViewModels);
        }

        // GET: Student/Create
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Create(ViewModels.Student.Create createStudentViewModel)
        {

            var student = _studentRepository.GetAll().FirstOrDefault(x => x.Matricule == createStudentViewModel.Matricule);

            if (student == null)
            {
                ModelState.AddModelError("Matricule", StudentResources.MatriculeNotFound);
            }
            else
            {
                if (student.Active)
                {
                    ModelState.AddModelError("Matricule", StudentResources.MatriculeAlreadyUsed);
                }
            }

            if (!ModelState.IsValid)
            {
                this.Flash(FlashMessageResources.ErrorsOnPage, FlashEnum.Error);
                return View(createStudentViewModel);
            }



            Mapper.Map(createStudentViewModel, student);


            student.Active = true;
            student.Password = _accountService.HashPassword(createStudentViewModel.Password);
            student.UserName = createStudentViewModel.Matricule.ToString();
            student.Roles = new List<UserRole>()
            {
                new UserRole() {RoleName = RoleName.Student}
            };
            _studentRepository.Update(student);
            string message = String.Format(StudentToCoordinator.CreateStudent, student.FirstName, student.LastName);

            _notificationService.SendNotificationToAllCoordinator(StudentToCoordinator.CreateStudentTitle, message);
            _mailler.SendEmail(student.Email, EmailAccountCreation.Subject, EmailAccountCreation.Message + EmailAccountCreation.EmailLink);
            this.Flash(FlashMessageResources.CreateAccountSuccess, FlashEnum.Success);
            return RedirectToAction(MVC.Student.CreateConfirmation());
        }

        [Authorize(Roles = RoleName.Student)]
        public virtual ActionResult Edit()
        {
            var userID = _httpContextService.GetUserId();

            var student = _studentRepository.GetById(userID);

            if (student != null)
            {
                var studentEditPageViewModel = Mapper.Map<ViewModels.Student.Edit>(student);

                return View(studentEditPageViewModel);
            }
            return HttpNotFound();
        }


        [Authorize(Roles = RoleName.Student)]
        [HttpPost]
        public virtual ActionResult Edit(ViewModels.Student.Edit editStudentViewModel)
        {
            var student = _studentRepository.GetById(editStudentViewModel.Id);
            if (student == null)
            {
                return HttpNotFound();
            }

            if (!editStudentViewModel.OldPassword.IsNullOrWhiteSpace())
            {
                if (!PasswordHash.ValidatePassword(editStudentViewModel.OldPassword, student.Password))
                {
                    ModelState.AddModelError("OldPassword", StudentResources.OldPasswordInvalid);
                }
            }

            

            if (!ModelState.IsValid)
            {
                this.Flash(FlashMessageResources.ErrorsOnPage, FlashEnum.Error);
                return View(editStudentViewModel);
            }
            if (!editStudentViewModel.PasswordConfirmation.IsNullOrWhiteSpace())
            {
                editStudentViewModel.Password = PasswordHash.CreateHash(editStudentViewModel.PasswordConfirmation);
            }
            if (editStudentViewModel.Password == null)
            {
                editStudentViewModel.Password = student.Password;
            }
            Mapper.Map(editStudentViewModel, student);

            _studentRepository.Update(student);
            this.Flash(FlashMessageResources.EditSuccess, FlashEnum.Success);
            return RedirectToAction(MVC.Student.Index());
        }

        [Authorize(Roles = RoleName.Student)]
        public virtual ActionResult DisplayStageList()
        {
            var stages = _stageRepository.GetAll().ToList();
            var stagesAccepted = stages.Where(x => x.Status == StageStatus.Accepted && Convert.ToDateTime(x.LimitDate) >= DateTime.Today);
            var studentStageListViewModels = Mapper.Map<IEnumerable<ViewModels.Student.StageList>>(stagesAccepted);

            return View(studentStageListViewModels);

        }


        public virtual ActionResult ApplyStage(int id)
        {
            var stage = _stageRepository.GetById(id);

            if (stage != null)
            {
                var applyViewModel = new ViewModels.Student.Apply();
                applyViewModel.IdStage = id;
                applyViewModel.IdStudent = _httpContextService.GetUserId();
                return View(applyViewModel);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public virtual ActionResult ApplyStage(IEnumerable<HttpPostedFileBase> files, ViewModels.Student.Apply applyStudentViewModel)
        {
            var stage = _stageRepository.GetById(applyStudentViewModel.IdStage);
            var studentID = _httpContextService.GetUserId();
            if (stage == null)
            {
                ViewBag.Message = StudentResources.NoFileToUpload;
                return HttpNotFound();
            }
            var appliedStages = _applyRepository.GetAll().Where(x => x.IdStudent == studentID);
            if (appliedStages != null)
            {
                foreach (var appliedStage in appliedStages)
                {
                    if (stage.Id == appliedStage.IdStage)
                    {
                        this.Flash(FlashMessageResources.AlreadyApplied, FlashEnum.Info);
                        return View(applyStudentViewModel);
                    }
                }
            }

            if (files.Any(file => file == null || (!file.FileName.Contains(".pdf") && !file.FileName.Contains(".do"))))
            {
                this.Flash(FlashMessageResources.InvalidFile, FlashEnum.Error);
                return View(applyStudentViewModel);
            }
            var readFile = new ReadFile();

            if (readFile.ReadFileCVLetter(files, Server, applyStudentViewModel.IdStage, applyStudentViewModel.IdStudent))
            {
                var files1 = files.ToList();
                applyStudentViewModel.Cv = applyStudentViewModel.IdStage +"-" + applyStudentViewModel.IdStudent + "-CV-" + files1[0].FileName;
                applyStudentViewModel.Letter = applyStudentViewModel.IdStage + "-" + applyStudentViewModel.IdStudent + "-LP-" + files1[1].FileName;
                var newApplicationStudent = Mapper.Map<Stagio.Domain.Entities.Apply>(applyStudentViewModel);
                newApplicationStudent.Status = 0;   //0 = En attente
                newApplicationStudent.DateApply = DateTime.Now;
                _applyRepository.Add(newApplicationStudent);
                _stageRepository.Update(stage);
                TempData["files"] = files;
                var student = _studentRepository.GetById(applyStudentViewModel.IdStudent);
               
                
                string messageToCoordinator = String.Format(StudentToCoordinator.ApplyMessage, student.FirstName, student.LastName, stage.Id, stage.StageTitle);
                
                _notificationService.SendNotificationToAllCoordinator(StudentToCoordinator.ApplyTilte, messageToCoordinator);
                
                string messageToContactEnterprise = String.Format(StudentToContactEnterprise.ApplyMessage, student.FirstName, student.LastName, stage.Id, stage.StageTitle);

                _notificationService.SendNotificationToAllContactEnterpriseOf(stage.CompanyName, StudentToContactEnterprise.ApplyTitle, messageToContactEnterprise);
                this.Flash(FlashMessageResources.AddSuccess, FlashEnum.Success);
                return RedirectToAction(MVC.Student.ApplyConfirmation());
            }
            else
            {
                this.Flash(FlashMessageResources.ErrorsOnPage, FlashEnum.Error);
                return View(applyStudentViewModel);
            }
        }

        public virtual ActionResult ApplyConfirmation()
        {
            try
            {
                var files = TempData["files"] as IEnumerable<HttpPostedFileBase>;
                return View(files.ToList());
            }
            catch (Exception)
            {

                return HttpNotFound();
            }
            
            
        }
        [Authorize(Roles = RoleName.Student)]
        public virtual ActionResult ApplyRemoveConfirmation(int id)
        {
            var stageApply = _applyRepository.GetById(id);
            if (stageApply == null)
            {
                this.Flash(FlashMessageResources.ApplyNotExist, FlashEnum.Warning);
                return RedirectToAction(MVC.Student.ApplyList());
            }
            var student = _studentRepository.GetById(_httpContextService.GetUserId());
            if (stageApply.IdStudent != student.Id)
            {
                this.Flash(FlashMessageResources.NotAccessApply, FlashEnum.Warning);
                return RedirectToAction(MVC.Student.ApplyList());
            }
            stageApply.Status = StatusApply.Removed;
            _applyRepository.Update(stageApply);
            
            var stage = _stageRepository.GetById(stageApply.IdStage);
            string message = String.Format(StudentToCoordinator.RemoveApplyMessage, student.FirstName, student.LastName, stage.Id, stage.StageTitle);
            _notificationService.SendNotificationToAllCoordinator(StudentToCoordinator.RemoveApplyTitle, message);
            this.Flash(FlashMessageResources.ApplyDelete, FlashEnum.Warning);
            
            return View();
        }
        [Authorize(Roles = RoleName.Student)]
        public virtual ActionResult ApplyReApplyConfirmation(int id)
        {
            var stageApply = _applyRepository.GetById(id);
            if (stageApply == null)
            {
                this.Flash(FlashMessageResources.ApplyNotExist, FlashEnum.Warning);
                return RedirectToAction(MVC.Student.ApplyList());
            }
            if (stageApply.IdStudent != _httpContextService.GetUserId())
            {
                this.Flash(FlashMessageResources.NotAccessApply, FlashEnum.Warning);
                return RedirectToAction(MVC.Student.ApplyList());
            }
            stageApply.Status = StatusApply.Waitting;
            _applyRepository.Update(stageApply);
            this.Flash(FlashMessageResources.ApplyReactivate, FlashEnum.Info);
            return View();
        }

        [Authorize(Roles = RoleName.Student)]
        public virtual ActionResult ApplyList()
        {
            var appliedStages = _applyRepository.GetAll().ToList();
            var studentSpecificApplies = appliedStages.Where(x => x.IdStudent == _httpContextService.GetUserId());
            var stages = _stageRepository.GetAll().ToList();

            var studentStageListViewModels = Mapper.Map<IEnumerable<ViewModels.Student.AppliedStages>>(studentSpecificApplies).ToList();

            foreach (var appliedStage in studentStageListViewModels)
            {
                foreach (var stage in stages)
                {
                    if (appliedStage.IdStage == stage.Id)
                    {
                        appliedStage.stageTitle = stage.StageTitle;
                    }
                }

            }

            return View(studentStageListViewModels);
        }



        public virtual ActionResult CreateConfirmation()
        {
            return View();
        }


        public virtual ActionResult Download(string file)
        {
            var readFile = new ReadFile();
            try
            {
                return File(readFile.Download(file), System.Net.Mime.MediaTypeNames.Application.Octet, file);
            }
            catch (Exception)
            {
                return RedirectToAction(MVC.Student.Index());
            }
        }


    }
}

