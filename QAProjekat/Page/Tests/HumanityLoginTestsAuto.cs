using System;
using System.Collections.Generic;
using System.Text;
using QAProjekat.Page.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace QAProjekat.Page.Tests
{
    [TestFixture]
    public class HumanityLoginTestsAuto
    {
        IWebDriver wd;
        HumanityLogIn loginModel;
        [SetUp]
        public void setup()
        {
            wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            loginModel = new HumanityLogIn(wd);
            loginModel.NavigateTo();
        }

        [TearDown]
        public void tearDown()
        {
            wd.Quit();
        }

        [Test]
        public void LogInTestRight()
        {

            loginModel.SendEmail(Constants.EMAIL)
            .SendPass(Constants.PASS)
            .ClickLogin();
            System.Threading.Thread.Sleep(5000); //stavljeno je jer mi se previse brzo ucita i test mi ne prolazi iako je tacan unos
            Assert.IsTrue(wd.Url.Contains(HumanityMenu.URL));

        }

        [Test]
        public void LogInTestWrong()
        {

            loginModel.SendEmail("bozabozic@gmail.com")
            .SendPass("wrong password")
            .ClickLogin();
            System.Threading.Thread.Sleep(5000); //stavljeno je jer mi se previse brzo ucita i test mi ne prolazi iako je tacan unos
            Assert.IsFalse(wd.Url.Contains(HumanityMenu.URL));

        }

        [Test]
        public void LogInTestWrongEmail()
        {

            loginModel.SendEmail("bozabozic@gmail.com")
            .SendPass(Constants.PASS)
            .ClickLogin();
            System.Threading.Thread.Sleep(5000); //stavljeno je jer mi se previse brzo ucita i test mi ne prolazi iako je tacan unos
            Assert.IsFalse(wd.Url.Contains(HumanityMenu.URL));

        }


        [Test]
        public void LogInTestWrongPassword()
        {

            loginModel.SendEmail(Constants.EMAIL)
            .SendPass("wrong password")
            .ClickLogin();
            System.Threading.Thread.Sleep(5000); //stavljeno je jer mi se previse brzo ucita i test mi ne prolazi iako je tacan unos
            Assert.IsFalse(wd.Url.Contains(HumanityMenu.URL));

        }


        [Test]
        public void LogInTestEmptyFields()
        {

            loginModel.SendEmail("")
            .SendPass("")
            .ClickLogin();
            System.Threading.Thread.Sleep(5000); //stavljeno je jer mi se previse brzo ucita i test mi ne prolazi iako je tacan unos
            Assert.IsFalse(wd.Url.Contains(HumanityMenu.URL));

        }
    }
}
