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
    public class HumanityPicture
    {
        IWebDriver wd;
        HumanityEditStaff editModel;

       [SetUp]
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
            HumanityStaff staffModel = menuModel.ClickStaff();
            System.Threading.Thread.Sleep(5000);
            editModel = staffModel.ClickName("Agent" + " " + "Kuper");
            editModel
                .ClickGetEditDetails();

        }
        [TearDown]
        public void tearDown()
        {
            wd.Quit();
        }
        [Test]
        public  void PictureTest()
        {
           
            string profilePictureBefore = editModel.ProfilePictureURL();               
            editModel.UploadPicture(Constants.PICUTRE_PATH).ClickSaveButton();
            System.Threading.Thread.Sleep(5000);
            string profilePictureAfter = editModel.ProfilePictureURL();
            Assert.AreNotEqual(profilePictureAfter, profilePictureBefore);
            

        }



    }
}
