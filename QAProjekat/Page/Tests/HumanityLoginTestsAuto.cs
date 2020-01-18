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
            ExcelUtility.OpenFile(Constants.LOGIN_EXCEL_PATH);
            ExcelUtility.LoadWorkSheet(0);
            for (int i = 1; i < ExcelUtility.GetRowCount(); i++)
            {
                
                string email = ExcelUtility.GetDataAt(i, 0);
                string pass = ExcelUtility.GetDataAt(i, 1);
                HumanityHome.NavigateTo(wd);
                System.Threading.Thread.Sleep(3000);
                HumanityHome.ClickLogin(wd);
                System.Threading.Thread.Sleep(3000);
                HumanityLogIn.SendEmail(wd, email);
                HumanityLogIn.SendPass(wd, pass);
                HumanityLogIn.ClickLogin(wd);
                System.Threading.Thread.Sleep(3000);
                if (wd.Url.Contains(HumanityMenu.URL))
                {
                    Console.WriteLine("PASS, Register loaded successfully!");
                    ExcelUtility.SetData(i, "PASS");
                        
                }
                else
                {
                    Console.WriteLine("FAIL, Page failed loading!");
                    ExcelUtility.SetData(i, "FAIL");
                   
                }
               
                

                wd.Manage().Cookies.DeleteAllCookies(); //delete all cookies
               

            }
            ExcelUtility.CloseFile();
            wd.Quit();
            
        }
    }
}
