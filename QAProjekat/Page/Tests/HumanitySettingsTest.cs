using System;
using System.Collections.Generic;
using System.Text;
using QAProjekat.Page.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace QAProjekat.Page.Tests
{
    class HumanitySettingsTest
    {
        public static void SettingsTest()
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
            HumanitySettings settingsModel = menuModel.ClickSettings();
            settingsModel.SelectCountry("Serbia")
            .SelectLanguage("American English")
            .SelectTimeFormat("12 hour")
            .ClickSave();
            System.Threading.Thread.Sleep(3000);
            if(settingsModel.GetSelectedCountry() == "Serbia")
            {
                Console.WriteLine("PASS! Successfully selected country");
            } else
            {
                Console.WriteLine("FAIL! Selected country not right");
            }

            
           



        }
    }
}
