using System;
using System.Collections.Generic;
using System.Text;
using QAProjekat.Page.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace QAProjekat.Page.Tests
{
    class HumanityPicture
    {
        public static void PictureTest()
        {
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");
            HumanityLogIn loginModel = new HumanityLogIn(wd);
            HumanityMenu menuModel = loginModel.NavigateTo()
                .SendEmail(Constants.EMAIL)
                .SendPass(Constants.PASS)
                .ClickLogin();
            System.Threading.Thread.Sleep(5000);
            HumanityStaff staffModel = menuModel.ClickStaff();
            System.Threading.Thread.Sleep(5000);
            HumanityEditStaff editModel = staffModel.ClickName("Agent" + " " + "Kuper");
            editModel
                .ClickGetEditDetails();
            string profilePictureBefore = editModel.ProfilePictureURL();


                
            editModel.UploadPicture(Constants.PICUTRE_PATH).ClickSaveButton();
            System.Threading.Thread.Sleep(5000);

            string profilePictureAfter = editModel.ProfilePictureURL();
            if (profilePictureAfter != profilePictureBefore)
            {
                Console.WriteLine("PASS! Successfully changed image!");
            } else
            {
                Console.WriteLine("FAIL! Profile picture url is not changed after upload");
            }

            wd.Quit();







        }



    }
}
