﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Stagio.Web.Automation.PageObjects;
using Stagio.Web.Automation.PageObjects.ContactEnterprise;

namespace Stagio.Web.AcceptanceTests.ContactEnterpriseTests
{
    [TestClass]
    public class ContactEnterpriseControllerCreateTests : BaseTests
    {
        [TestMethod]
        public void contact_enterprise_should_be_able_to_access_create_profil_page()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(ContactEnterpriseUsername, ContactEnterprisePassword);

            CreateContactEnterprisePage.GoToByUrl();

            CreateContactEnterprisePage.IsDisplayed.Should().BeTrue();
            
        }

        [TestMethod]
        public void contact_enterprise_create_should_create_account()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(ContactEnterpriseUsername, ContactEnterprisePassword);

            CreateContactEnterprisePage.GoToByUrl();

            CreateContactEnterprisePage.CreateContactEnterpriseWithoutInvitation();

            CreateContactEnterprisePage.ConfirmationIsDisplayed.Should().BeTrue();
            
        }


        
    }
}
