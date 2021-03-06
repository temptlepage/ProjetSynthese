﻿
using System;
using System.Collections.Specialized;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Ploeh.AutoFixture;
using Stagio.Domain.Entities;

namespace Stagio.Web.UnitTests.ControllerTests.ContactEnterpriseTests
{
    [TestClass]
    public class ContactEnterpriseControllerCreateStageTests : ContactEnterpriseControllerBaseClassTests
    {
        [TestMethod]
        public void enterprise_createStage_get_should_return_createStage_view()
        {
            var result = enterpriseController.CreateStage() as ViewResult;

            result.ViewName.Should().Be("");
        }

        [TestMethod]
        public void enterprise_createStage_post_should_return_default_view_when_modelState_is_not_valid()
        {
            var contactEnterprise = _fixture.Create<ContactEnterprise>();
            httpContext.GetUserId().Returns(contactEnterprise.Id);
            enterpriseRepository.GetById(contactEnterprise.Id).Returns(contactEnterprise);
            var stageViewModel = _fixture.Create<ViewModels.Stage.Create>();
            enterpriseController.ModelState.AddModelError("Error", "Error");

            var result = enterpriseController.CreateStage(stageViewModel) as ViewResult;

            result.ViewName.Should().Be("");
        }

        [TestMethod]
        public void enterprise_createStage_post_should_return_index_on_success()
        {
            var contactEnterprise = _fixture.Create<ContactEnterprise>();
            httpContext.GetUserId().Returns(contactEnterprise.Id);
            enterpriseRepository.GetById(contactEnterprise.Id).Returns(contactEnterprise);
            var stageViewModel = _fixture.Create<ViewModels.Stage.Create>();
            
            
            var result = enterpriseController.CreateStage(stageViewModel) as RedirectToRouteResult;
            var action = result.RouteValues["Action"];

            action.ShouldBeEquivalentTo(MVC.ContactEnterprise.Views.ViewNames.CreateStageSucceed);
        }

        [TestMethod]
        public void enterprise_createStageSucceed_should_render_view()
        {
            var result = enterpriseController.CreateStageSucceed() as ViewResult;

            result.ViewName.Should().Be("");
        }


        [TestMethod]
        public void contact_enterprise_save_draft_should_render_confirmation_page()
        {
            var contactEnterprise = _fixture.Create<ContactEnterprise>();
            httpContext.GetUserId().Returns(contactEnterprise.Id);
            enterpriseRepository.GetById(contactEnterprise.Id).Returns(contactEnterprise);
            var stageViewModel = _fixture.Create<ViewModels.Stage.Create>();

            var result = enterpriseController.CreateStage(stageViewModel, "Sauvegarder comme brouillon") as ViewResult;

            result.ViewName.Should().Be(MVC.ContactEnterprise.Views.ViewNames.DraftConfirmation);
        }
    }

  
}
