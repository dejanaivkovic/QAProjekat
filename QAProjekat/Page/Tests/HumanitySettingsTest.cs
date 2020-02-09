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
    class HumanitySettingsTest
    {
        IWebDriver wd;
        HumanitySettings settingsModel;
        [OneTimeSetUp]
        public void setup()
        {
            wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();

            HumanityLogIn loginModel = new HumanityLogIn(wd);
            HumanityMenu menuModel = loginModel.NavigateTo()
                .SendEmail(Constants.EMAIL)
                .SendPass(Constants.PASS)
                .ClickLogin();
            System.Threading.Thread.Sleep(5000);
            settingsModel = menuModel.ClickSettings();
        }
        [OneTimeTearDown]
        public void tearDown()
        {
            wd.Quit();
        }
        [Test]
        public  void SettingsCountryTest()
        {
            settingsModel.SelectCountry("Serbia")
            .ClickSave();
            System.Threading.Thread.Sleep(3000);
            Assert.AreEqual(settingsModel.GetSelectedCountry(), "Serbia");
         
        }
        [Test]
        public void SettingsLanguageTest()
        {
            settingsModel.SelectLanguage("American English")
              .ClickSave();
            System.Threading.Thread.Sleep(3000);    
            Assert.AreEqual(settingsModel.GetSelectedLanguage(), "American English");  
        }
        [Test]
        public void SettingsTimeFormatTest()
        {
            settingsModel.SelectTimeFormat("12 hour")
                  .ClickSave();
            System.Threading.Thread.Sleep(3000);
            Assert.AreEqual(settingsModel.GetSelectedTimeFormat(), "12 hour");
        }
    }
}
