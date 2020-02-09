using System;
using System.Collections.Generic;
using System.Text;
using QAProjekat.Page.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;


namespace QAProjekat.Page.Tests
{
    public class HumanityLoginTestsAuto
    {

        public static void LogInTest()
        {

            IWebDriver wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver initialized!!");
            
            ExcelUtility excel = new ExcelUtility(Constants.LOGIN_EXCEL_PATH);
            excel.LoadWorkSheet(0);
            for (int i = 1; i < excel.GetRowCount(); i++)
            {

                
                string email = excel.GetDataAt(i, 0);
                string pass = excel.GetDataAt(i, 1);
                HumanityHome homeModel = new HumanityHome(wd);
                wd.Manage().Cookies.DeleteAllCookies();
                homeModel.NavigateTo();
                
                System.Threading.Thread.Sleep(3000);
                HumanityLogIn loginModel = homeModel.ClickLogin();
                System.Threading.Thread.Sleep(5000);
                //ovde sam stavila DeleteAllCookies jer sam skontala da ako pukne program sledeci put kad se pokrene kao da je selenium zapamtio i ostanu mi 
                wd.Manage().Cookies.DeleteAllCookies(); //delete all cookies
                loginModel.SendEmail(email)
                    .SendPass(pass)
                    .ClickLogin();
                System.Threading.Thread.Sleep(3000);
                if (wd.Url.Contains(HumanityMenu.URL))
                {
                    Console.WriteLine("PASS, Register loaded successfully!");
                
                }
                else
                {
                    Console.WriteLine("FAIL, Page failed loading!");
                    
                }
                wd.Manage().Cookies.DeleteAllCookies(); //delete all cookies




            }
            wd.Quit();

        }
    }
}
