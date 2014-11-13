﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stagio.Web.Automation.PageObjects;
using Stagio.Web.Automation.PageObjects.Coordinator;

namespace Stagio.Web.AcceptanceTests.CoordinatorTests
{
    [TestClass]
    public class CoordinatorControllerStudentListTests : BaseTests
    {
        [TestMethod]
        public void coordinator_should_be_able_to_access_StudentList_page_if_logged_in()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(CoordonatorUsername, CoordonatorPassword);
            StudentListCoordinatorPage.GoTo();

            Assert.IsTrue(StudentListCoordinatorPage.IsDisplayed);

        }

        [TestMethod]
        public void coordinator_should_not_be_able_to_access_StudentList_page_if_not_logged_in()
        {
            StudentListCoordinatorPage.GoToByUrl();

            Assert.IsTrue(LoginPage.IsDisplayed);

        }

        [TestMethod]
        public void coordinator_should_be_able_to_access_student_apply_detail()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(CoordonatorUsername, CoordonatorPassword);

            StudentListCoordinatorPage.GoTo();
            StudentListCoordinatorPage.AccessStudent1ApplyList();
        }

        [TestMethod]
        public void coordinator_should_be_able_to_see_StudentList_with_students()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs(CoordonatorUsername, CoordonatorPassword);
            StudentListCoordinatorPage.GoTo();

            Assert.AreNotEqual(0, StudentListCoordinatorPage.CountNbStudents());

        }
    }
}