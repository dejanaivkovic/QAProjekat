using System;
using System.Collections.Generic;
using System.Text;
using QAProjekat.Page.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace QAProjekat.Page.Tests
{
    public class HumanityLoginTestsManual
    {
        public static readonly string EMAIL = "kuper@poi.com";
        public static readonly string PASS = "agentkuper123";
        public static void LogInTest()
        {
            
            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver Initialized!");
            HumanityLogIn loginModel = new HumanityLogIn(wd);
            loginModel.NavigateTo();
            loginModel.SendEmail(EMAIL);
            loginModel.SendPass(PASS);
            loginModel.ClickLogin();
            System.Threading.Thread.Sleep(5000); //stavljeno je jer mi se previse brzo ucita i test mi ne prolazi iako je tacan unos
            if(wd.Url.Contains(HumanityMenu.URL))
            {
                Console.WriteLine("PASS, Register loaded successfully!");
            }
            else
            {
                Console.WriteLine("FAIL, Page failed loading!");
            }


            wd.Quit();


          

        }




    }
}
