﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Stagio.DataLayer;
using Stagio.Domain.Entities;

namespace Stagio.Web.Controllers
{
    public partial class StudentController : Controller
    {
        private readonly IEntityRepository<Student> _studentRepository;

        /*public StudentController()
        {

        }*/

        public StudentController(IEntityRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }


        // GET: Student
        public virtual ActionResult Index()
        {
            return View();
        }

        // GET: Student/Details/5
        public virtual ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public virtual ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public virtual ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public virtual ActionResult Edit(int id)
        {
            var student = _studentRepository.GetById(id);

            if (student != null)
            {
                var studentEditPageViewModel = Mapper.Map<ViewModels.Student.Edit>(student);

                return View(studentEditPageViewModel);
            }
            return HttpNotFound();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public virtual ActionResult Edit(ViewModels.Student.Edit editStudentViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var student = _studentRepository.GetById(editStudentViewModel.Id);

                    if (student == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        student.Telephone = editStudentViewModel.Telephone;
                        student.Password = editStudentViewModel.Password;
                        _studentRepository.Update(student);

                        return RedirectToAction(MVC.Home.Index());
                    }

                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public virtual ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public virtual ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
