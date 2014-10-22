﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using AutoMapper;
using FluentAssertions;
using NSubstitute;
using Stagio.Domain.Entities;
using Ploeh.AutoFixture;
using Stagio.Web.Controllers;
using Stagio.Web.UnitTests.ControllerTests.EnterpriseTests;

namespace Stagio.Web.UnitTests.ControllerTests.CoordinatorTests
{
    [TestClass]
    public class CoordinatorControllerInviteTests : CoordinatorControllerBaseClassTests
    {
        [TestMethod]
        public void invite_get_should_render_default_view()
        {
            var result = coordinatorController.InviteEnterprise() as ViewResult;

            result.ViewName.Should().Be("");
        }

        [TestMethod]
        public void invite_post_should_return_default_view_when_modelState_is_not_valid()
        {
            IEnumerable<int> selectedObjects = new int[] { 1, 2 };
            string message = "test";
            coordinatorController.ModelState.AddModelError("Error", "Error");

            var result = coordinatorController.InviteEnterprise(selectedObjects, message) as ViewResult;

            result.ViewName.Should().Be("");
        }

        [TestMethod]
        public void invite__post_should_return_index_view_after_sending_if_email_is_valid()
        {
            var enterprise1 = _fixture.Create<Enterprise>();
            enterprise1.Email = "test@test.com";
            enterpriseRepository.GetById(enterprise1.Id).Returns(enterprise1);
            IEnumerable<int> selectedObjects = new int[] { enterprise1.Id };
            string message = "test";
            mailler.SendEmail(enterprise1.Email, "Test", message).ReturnsForAnyArgs(true);

            var routeResult = coordinatorController.InviteEnterprise(selectedObjects, message) as RedirectToRouteResult;
            var routeAction = routeResult.RouteValues["Action"];

            routeAction.Should().Be("Index");
        }

        [TestMethod]
        public void invite__post_should_return_default_view_if_email_is_invalid()
        {
            var enterprise1 = _fixture.Create<Enterprise>();
            enterprise1.Email = "invalidEmail";
            enterpriseRepository.GetById(enterprise1.Id).Returns(enterprise1);
            IEnumerable<int> selectedObjects = new int[] { enterprise1.Id };
            string message = "test";

            var result = coordinatorController.InviteEnterprise(selectedObjects, message) as ViewResult;

            result.ViewName.Should().Be("");
        }
    }
}
