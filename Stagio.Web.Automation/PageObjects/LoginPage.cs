﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;
using Stagio.Web.Automation.Selenium;
using Stagio.Domain.Entities;



namespace Stagio.Web.Automation.PageObjects
{
    public class LoginPage
    {
        public static bool IsDisplayed
        {
            get
            {
                try
                {
                    Driver.Instance.FindElement(By.Id("login-page"));
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static void GoTo()
        {
            Navigation.AllUsers.Login.Select();
        }

        public static void LoginAs(string username, string password)
        {
            var loginInput = Driver.Instance.FindElement(By.Id("Username"));
            loginInput.SendKeys(username);

            var passwordInput = Driver.Instance.FindElement(By.Id("Password"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("login-submit"));
            loginButton.Click();
        }

        public static bool VerifyCoordinatorLogin()
        {
            var body = Driver.Instance.FindElement(By.ClassName("navbar"));

            if (body.Text.Contains("Jean-Dominic Rousseau"))
            {
                return true;
            }
            return false;
        }

        public static void Logout()
        {
            var logOut = Driver.Instance.FindElement(By.Id("logout-link"));
            logOut.Click();
        }

        public static bool VerifyLogout()
        {
             var body = Driver.Instance.FindElement(By.ClassName("navbar"));

            if (body.Text.Contains("Se connecter"))
            {
                return true;
            }
            return false;
        }
    }
}