using System;
using System.Collections.Generic;
using System.Text;
using QAProjekat.Page.Objects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;

namespace QAProjekat.Page.Tests
{
    public class HumanityAddNewEmployeeTestsManual
    {
        public static readonly string URL = "https://kuper.humanity.com/app/staff/assignstaff";
        public static readonly string NAME = "Bozidar2";
        public static readonly string LAST_NAME = "Boozic2";
        public static readonly string EMAIL_1 = "bozidarbozic1@boza.com";
        public static void AddEmployeeTest()
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
            staffModel
                .ClickAddEmployess()
                .SendName(NAME, 1)
                .SendLastName(LAST_NAME, 1)
                .SendEmail(EMAIL_1, 1)
                .ClickSave();
            System.Threading.Thread.Sleep(5000);
            if (wd.Url.Contains(URL)) //prvi korak za proveru, da li je otisao na pravu stranicu, ali to nije dovoljno da bi znali
            {
                staffModel.NavigateTo();
                System.Threading.Thread.Sleep(5000);
                try
                {
                    staffModel.ClickName(NAME + " " + LAST_NAME);
                    Console.WriteLine("PASS, Register loaded successfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("FAIL, Employee not present on page!");
                }
                
            }
            else
            {
                Console.WriteLine("FAIL, Page failed loading!");
            }


            wd.Quit();




        }



    }
}
