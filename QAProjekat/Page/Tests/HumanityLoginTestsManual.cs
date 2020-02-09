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
    public class HumanityLoginTestsManual
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
        public void LogInTest()
        {
            
                loginModel.SendEmail(Constants.EMAIL)
                .SendPass(Constants.PASS)
                .ClickLogin();
            System.Threading.Thread.Sleep(5000); //stavljeno je jer mi se previse brzo ucita i test mi ne prolazi iako je tacan unos
            Assert.IsTrue(wd.Url.Contains(HumanityMenu.URL));
           
        }

      
    }
}
