﻿using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Stagio.Web.Automation.PageObjects.ContactEnterprise;

namespace Stagio.Web.AcceptanceTests.ContactEnterpriseTests
{
    [TestClass]
    public class ContactEnterpriseListStudentApplyTests : BaseTests
    {
        [TestMethod]
        public void contactEnterprise_can_see_a_list_of_student_for_stage()
        {
            StudentApplyContactEnterprisePage.GoToByUrl();

            StudentApplyContactEnterprisePage.IsDisplayed.Should().BeTrue();
            
        }

        [TestMethod]
        public void contactEnterprise_can_click_on_a_student()
        {
            StudentApplyContactEnterprisePage.GoToByUrl();

            StudentApplyContactEnterprisePage.ButtonIsDisplayed().Should().BeTrue();
            
        }
    }
}