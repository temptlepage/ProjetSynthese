﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Ploeh.AutoFixture;
using Stagio.Domain.Entities;
using Stagio.Web.ViewModels.Apply;
using Stagio.Web.ViewModels.ContactEnterprise;
using Stagio.Web.ViewModels.Stage;

namespace Stagio.Web.UnitTests.ControllerTests.ContactEnterpriseTests
{
    [TestClass]
    public class ContactEnterpriseControllerListStageTests : ContactEnterpriseControllerBaseClassTests
    {

        [TestMethod]
        public void contactEnterpriseController_listStage_should_render_view()
        {
            var contactEnterprise = _fixture.Create<ContactEnterprise>();
            var applies = _fixture.CreateMany<Apply>(2);
            var interviews = _fixture.CreateMany<Interview>(2);
            applyRepository.GetAll().Returns(applies.AsQueryable());
            interviewRepository.GetAll().Returns(interviews.AsQueryable());
            contactEnterprise.EnterpriseName = "Test";
            var stages = _fixture.CreateMany<Stage>(5).AsQueryable();
            foreach (var stage in stages)
            {
                stage.CompanyName = contactEnterprise.EnterpriseName;
            }
            stageRepository.GetAll().Returns(stages);
            httpContext.GetUserId().Returns(contactEnterprise.Id);
            enterpriseRepository.GetById(contactEnterprise.Id).Returns(contactEnterprise);

            var result =  enterpriseController.ListStage() as ViewResult;

            result.ViewName.Should().Be("");

        }


        [TestMethod]
        public void contactEnterpriseController_listStage_should_render_view_with_stages()
        {
            var contactEnterprise = _fixture.Create<ContactEnterprise>();
            var applies = _fixture.CreateMany<Apply>(2).ToList();
            var interviews = _fixture.CreateMany<Interview>(2).ToList();
            
            contactEnterprise.EnterpriseName = "Test";
            var stages = _fixture.CreateMany<Stage>(5).ToList();
            foreach (var stage in stages)
            {
                stage.CompanyName = contactEnterprise.EnterpriseName;
                
            }
            applies[1].IdStage = stages[1].Id;
            
            interviews[1].StageId = stages[1].Id;
            interviews[1].DateAcceptOffer = DateTime.Today.ToShortDateString();
            applyRepository.GetAll().Returns(applies.AsQueryable());
            interviewRepository.GetAll().Returns(interviews.AsQueryable());
            stageRepository.GetAll().Returns(stages.AsQueryable());
            httpContext.GetUserId().Returns(contactEnterprise.Id);
            enterpriseRepository.GetById(contactEnterprise.Id).Returns(contactEnterprise);

            var result = enterpriseController.ListStage() as ViewResult;
            var model = result.Model as List<ListStage>;

            model.Count.Should().NotBe(0);


        }


        [TestMethod]
        public void contactEnterpriseController_listeStage_should_render_view_with_0_stages()
        {
            var contactEnterprise = _fixture.Create<ContactEnterprise>();
            contactEnterprise.EnterpriseName = "Test";
            var stages = _fixture.CreateMany<Stage>(5).AsQueryable();
            stageRepository.GetAll().Returns(stages);
            httpContext.GetUserId().Returns(contactEnterprise.Id);
            enterpriseRepository.GetById(contactEnterprise.Id).Returns(contactEnterprise);

            var result = enterpriseController.ListStage() as ViewResult;
            var model = result.Model as List<ListStage>;

            result.ViewName.Should().Be("");

        }


        public void contactEnterpriseController_listStage_should_just_render_view_with_stages_of_the_specific_contact()
        {
            //Todo : Vérifier avec un login

        }
    }
}
