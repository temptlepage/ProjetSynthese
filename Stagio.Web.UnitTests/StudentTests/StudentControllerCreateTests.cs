﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Ploeh.AutoFixture;
using Stagio.Domain.Entities;
using AutoMapper;
using FluentAssertions;

namespace Stagio.Web.UnitTests.StudentTests
{
    [TestClass]
    public class StudentControllerCreateTests : AllControllersBaseClassTests
    {
        [TestMethod]
        public void student_create_get_should_return_create_view()
        {

        }

        [TestMethod]
        public void student_create_post_should_return_default_view_when_modelState_is_not_valid()
        { 
        
        }

        [TestMethod]
        public void student_create_post_should_return_default_view_when_matricule_is_not_in_the_list()
        {

        }

        [TestMethod]
        public void student_create_post_should_return_default_view_when_firstname_dont_correspond_with_matricule()
        {

        }

        [TestMethod]
        public void student_create_post_should_return_default_view_when_lastname_dont_correspond_with_matricule()
        {

        }

        [TestMethod]
        public void student_create_post_should_return_index_on_success()
        {
            var students = _fixture.CreateMany<Student>(3);
            var student = students.First();
            student.Activated = false;

            studentRepository.GetAll().Returns(students.AsQueryable());

            var viewModel = _fixture.Create<ViewModels.Student.Create>();
            viewModel.Matricule = student.Matricule;
            viewModel.FirstName = student.FirstName;
            viewModel.LastName = student.LastName;
            viewModel.PasswordConfirmation = viewModel.Password;

            var routeResult = studentController.Create(viewModel) as RedirectToRouteResult;
            var routeAction = routeResult.RouteValues["Action"];

            routeAction.Should().Be(MVC.Home.Views.ViewNames.Index);
        }
    }
}
