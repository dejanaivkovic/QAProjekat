using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using QAProjekat.Page.Objects;
using QAProjekat.Page.Tests;

namespace QAProjekat
{
    class Program
    {
        static void Main(string[] args)
        {

            //HumanityLogIn loginModel = new HumanityLogIn(wd);
            //HumanityLoginTestsManual.LogInTest();
            // HumanityLoginTestsAuto.LogInTest();
            //HumanityAddNewEmployeeTestAuto.AddEmployeeTest();
            // HumanityPicture.PictureTest();
            HumanityLoginTestsAuto.LogInTest();
            //HumanityAddNewEmployeeTestsManual.AddEmployeeTest();
            /*IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            HumanityLogIn.NavigateTo(wd);
            HumanityLogIn.SendEmail(wd, "kuper@poi.com");
            HumanityLogIn.SendPass(wd, "agentkuper123");

            HumanityLogIn.ClickLogin(wd);
            HumanityStaff.NavigateTo(wd);/*
            /* wd.Navigate().GoToUrl("https://www.humanity.com/");/*


             IWebElement dugme = wd.FindElement(By.XPath("//a[@class='cc-btn cc-dismiss']"));
             dugme.Click();
             IWebElement log = wd.FindElement(By.XPath("//input[@id='free-trial-link-01']"));
             log.Click();
             */
            //HumanityHome.RegisterButton1(wd);
            /*
            HumanityHome.NavigateTo(wd);
            HumanityHome.ClickCookies(wd);
            HumanityHome.SendFullName(wd, "Dejana Ivkovic");
            HumanityHome.SendWorkEmail(wd, "dejana@xm.com");

            //HumanityHome.ClickRegister2(wd);
            HumanityHome.ClickLogin(wd);
            HumanityMenu.NavigateTo(wd);
            */
            // HumanityHome.NavigateTo(wd);
            //HumanityHome.ClickLogin(wd);
            /* HumanityLogIn.NavigateTo(wd);
             HumanityLogIn.SendEmail(wd, "kuper@poi.com");
             HumanityLogIn.SendPass(wd, "agentkuper123");
             HumanityLogIn.ClickLogin(wd);
             HumanityMenu.ClickSettings(wd);
             HumanitySettings.SelectCountry(wd, "Serbia");
             HumanitySettings.SelectLanguage(wd, "Arabic (machine)");*/
            //HumanityMenu.ClickStaff(wd);
            // HumanityMenu.ClickStaff(wd);
            //HumanityAddEmployees.ClickAddEmployess(wd);
            //promeni ih!
            //HumanityAddEmployees.SendName(wd, "dru1", 1);
            //HumanityAddEmployees.SendLastName(wd, "drugi1", 1);
            //HumanityAddEmployees.SendEmail(wd, "bla1@blabla.com", 1);
            //HumanityAddEmployees.ClickSave(wd);
            /*HumanityProfile.ClickProfileIcon(wd);
            HumanityProfile.ClickAvailability(wd);
            Console.WriteLine("Verzija:");
            HumanityProfile.SendVersion(wd);
            */
        }
    }
}
