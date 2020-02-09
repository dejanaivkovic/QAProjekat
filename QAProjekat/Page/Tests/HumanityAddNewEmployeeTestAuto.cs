using System;
using System.Collections.Generic;
using System.Text;
using QAProjekat.Page.Objects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;
using NUnit.Framework;

namespace QAProjekat.Page.Tests
{
    [TestFixture]

    class HumanityAddNewEmployeeTestAuto
    {
        public static readonly string URL = "https://kuper.humanity.com/app/staff/assignstaff";
        IWebDriver wd;
       

        [SetUp]
        public void setup()
        {
            wd = new ChromeDriver(Constants.WEBDRIVER_PATH);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wd.Manage().Window.Maximize();
            
        }

        [TearDown]
        public void tearDown()
        {
            wd.Quit();
        }

        [Test]
        public void AddEmployeeTest()
        {
            HumanityLogIn loginModel = new HumanityLogIn(wd);
            HumanityMenu menuModel = loginModel.NavigateTo()
               .SendEmail(Constants.EMAIL)
               .SendPass(Constants.PASS)
               .ClickLogin();
            System.Threading.Thread.Sleep(5000);

            ExcelUtility excel = new ExcelUtility(Constants.ZAPOSLENI_EXCEL_PATH);
            for (int j = 0; j < 2; j++)
            {
                HumanityStaff staffModel = menuModel.ClickStaff();
                System.Threading.Thread.Sleep(5000);
                HumanityAddEmployees addEmployeesModel = staffModel.ClickAddEmployess();
                excel.LoadWorkSheet(j);
                for (int i = 1; i < excel.GetRowCount(); i++)
                {
                    string first_name = excel.GetDataAt(i, 0);
                    string last_name = excel.GetDataAt(i, 1);
                    string email = excel.GetDataAt(i, 2);
                    addEmployeesModel
                        .SendName(first_name, i)
                        .SendLastName(last_name, i)
                        .SendEmail(email, i);
                }

                addEmployeesModel.ClickSave();
                System.Threading.Thread.Sleep(5000);

                if (wd.Url.Contains(URL)) //prvi korak za proveru, da li je otisao na pravu stranicu, ali to nije dovoljno da bi znali
                {
                    staffModel.NavigateTo();
                    System.Threading.Thread.Sleep(5000);
                    for (int i = 1; i < excel.GetRowCount(); i++)
                    {
                        string first_name = excel.GetDataAt(i, 0);
                        string last_name = excel.GetDataAt(i, 1);
                        try
                        {

                            staffModel.GetByName(first_name + " " + last_name);

                            Console.WriteLine("PASS, Register loaded successfully!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("FAIL, Employee not present on page!" + first_name + " " + last_name);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("FAIL, Page failed loading!");
                }
            }


        }
    }
        


        


    
}
