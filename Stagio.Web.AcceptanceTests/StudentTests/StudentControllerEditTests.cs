﻿using System;
using System.Net.Mime;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Stagio.Web.AcceptanceTests.StudentTests
{
    [TestClass]
    public class StudentControllerEditTests : BaseTests
    {
        [TestMethod]
        public void student_should_be_able_to_edit_his_profil_if_id_is_valid()
        {
            AuthentificateTestUser(StudentUsername, StudentPassword);
            _driver.Navigate().GoToUrl("http://thomarelau.local/Student/Edit?id=1");
            
            try
            {
                _driver.FindElement(By.Id("edit-page"));
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Identifiant edit-page non trouvé sur la page.");
            }
        }

        [TestMethod]
        public void student_edit_should_update_his_profil_if_id_is_valid()
        {
            AuthentificateTestUser(StudentUsername, StudentPassword);
            const string NEW_TELEPHONE = "444-444-4444";
            const string OLD_PASSWORD = "qwerty12";
            const string NEW_PASSWORD = "asdfgh12";
            _driver.Navigate().GoToUrl("http://thomarelau.local/Student/Edit?id=1");
            _driver.FindElement(By.Id("Telephone")).Clear();
            _driver.FindElement(By.Id("Telephone")).SendKeys(NEW_TELEPHONE);
            _driver.FindElement(By.Id("OldPassword")).Clear();
            _driver.FindElement(By.Id("OldPassword")).SendKeys(OLD_PASSWORD);
            _driver.FindElement(By.Id("Password")).Clear();
            _driver.FindElement(By.Id("Password")).SendKeys(NEW_PASSWORD);
            _driver.FindElement(By.Id("PasswordConfirmation")).Clear();
            _driver.FindElement(By.Id("PasswordConfirmation")).SendKeys(NEW_PASSWORD);
            _driver.FindElement(By.Id("edit-button")).Click();
            _driver.FindElement(By.Id("edit-student")).Click();
            var telephoneDisplayed = _driver.FindElement(By.Id("Telephone")).GetAttribute("value");
            telephoneDisplayed.ShouldBeEquivalentTo(NEW_TELEPHONE);
        }

        [TestMethod]
        public void student_edit_should_redirect_to_index_if_updated()
        {
            AuthentificateTestUser(StudentUsername, StudentPassword);
            const string NEW_TELEPHONE = "444-444-4444";
            const string OLD_PASSWORD = "qwerty12";
            const string NEW_PASSWORD = "asdfgh12";
            _driver.Navigate().GoToUrl("http://thomarelau.local/Student/Edit?id=1");
            _driver.FindElement(By.Id("Telephone")).Clear();
            _driver.FindElement(By.Id("Telephone")).SendKeys(NEW_TELEPHONE);
            _driver.FindElement(By.Id("OldPassword")).Clear();
            _driver.FindElement(By.Id("OldPassword")).SendKeys(OLD_PASSWORD);
            _driver.FindElement(By.Id("Password")).Clear();
            _driver.FindElement(By.Id("Password")).SendKeys(NEW_PASSWORD);
            _driver.FindElement(By.Id("PasswordConfirmation")).Clear();
            _driver.FindElement(By.Id("PasswordConfirmation")).SendKeys(NEW_PASSWORD);
            _driver.FindElement(By.Id("edit-button")).Click();
            try
            {
                _driver.FindElement(By.Id("home-page"));
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Identifiant home-page non trouvé sur la page.");
            }

        }

        //TODO: Validation du mot de passe à faire lorsque le login sera disponible.
    }
}
