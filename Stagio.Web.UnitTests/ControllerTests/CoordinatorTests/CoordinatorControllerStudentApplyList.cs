﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Ploeh.AutoFixture;
using Stagio.Domain.Entities;
using Stagio.Web.ViewModels.Coordinator;

namespace Stagio.Web.UnitTests.ControllerTests.CoordinatorTests
{
    [TestClass]
    public class CoordinatorControllerStudentApplyList : CoordinatorControllerBaseClassTests
    {
        [TestMethod]
        public void coordinator_StudentApplyList_should_render_view()
        {
            var result = coordinatorController.StudentList() as ViewResult;

            result.ViewName.Should().Be("");
        }

        [TestMethod]
        public void coordinator_StudentApplyList_should_return_list_with_applies()
        {
            var student = _fixture.Create<Student>();
            var apply = _fixture.CreateMany<Apply>(1);
            var stages = _fixture.CreateMany<Stage>(3);
            var interview = _fixture.CreateMany<Interview>(1);
            stageRepository.GetAll().Returns(stages.AsQueryable());
            apply.FirstOrDefault().IdStudent = student.Id;
            apply.FirstOrDefault().IdStage = stages.FirstOrDefault().Id;
            applyRepository.GetAll().Returns(apply.AsQueryable());
            studentRepository.GetById(student.Id).Returns(student);
            interviewRepository.GetAll().Returns(interview.AsQueryable());
            studentRepository.GetById(student.Id).Returns(student);

            var result = coordinatorController.StudentApplyList(student.Id) as ViewResult;
            var model = result.Model as List<StudentApplyList>;

            model.Count.Should().NotBe(0);
        }

        [TestMethod]
        public void coordinator_StudentApplyList_should_return_empty_list_when_there_is_no_apply()
        {
            var student = _fixture.Create<Student>();
            studentRepository.GetById(student.Id).Returns(student);

            var result = coordinatorController.StudentApplyList(student.Id) as ViewResult;
            var model = result.Model as List<StudentApplyList>;

            model.Count.Should().Be(0);
        }

        [TestMethod]
        public void coordinator_StudentApplyList_should_return_httpnotfound_when_studentId_is_invalid()
        {
            var result = coordinatorController.StudentApplyList(INVALID_ID);

            result.Should().BeOfType<HttpNotFoundResult>();
        }
    }
}
