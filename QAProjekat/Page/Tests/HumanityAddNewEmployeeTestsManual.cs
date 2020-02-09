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
    public class HumanityAddNewEmployeeTestsManual
    {
        public static readonly string URL = "https://kuper.humanity.com/app/staff/assignstaff";
        IWebDriver wd;
        HumanityStaff staffModel;
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
            staffModel = menuModel.ClickStaff();
            System.Threading.Thread.Sleep(5000);
        }


        [TearDown]
        public void tearDown()
        {
            wd.Quit();
        }

        


        [Test]
        public void AddEmployeesTest()
        {
            string[] names = { "Prisvojni", "Nikola", "Boza", "Mikica" };
            string[] last_names = { "Pridevi", "", "Bozic", "Mili" };
            string[] emails = { "prisvojni@pridevi.com", "nikolic@nikola.com", "bozic@bozidar1.com", "" };
            HumanityAddEmployees add_employees = staffModel
                .ClickAddEmployess();
            for(int i = 0; i < names.Length; i++)
            {
                add_employees
                    .SendName(names[i], i+1)
                    .SendLastName(last_names[i], i + 1)
                    .SendEmail(emails[i], i + 1);
            }
            add_employees.ClickSave();
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(wd.Url.Contains(URL));
            staffModel.NavigateTo();
            System.Threading.Thread.Sleep(5000);
            for (int i = 1; i < names.Length; i++)
            {
                string first_name = names[i];
                string last_name = last_names[i];
                staffModel.GetByName(first_name + " " + last_name);
                // ne treba try/catch jer ako se desi exception test ce da pukne, sto je i ocekivano

            }
        }

        [Test]
        public void AddEmployeesTestWrong()
        {
            string[] names = { " ", "Milomir", "Asia" };
            string[] last_names = { "dragica", "milo", "Oceania" };
            string[] emails = { "dragica@draga.com", "milo@millo.com", "oceania@asia.com"};
            HumanityAddEmployees add_employees = staffModel
                .ClickAddEmployess();
            for (int i = 0; i < names.Length; i++)
            {
                add_employees
                    .SendName(names[i], i + 1)
                    .SendLastName(last_names[i], i + 1)
                    .SendEmail(emails[i], i + 1);
            }
            add_employees.ClickSave();
            System.Threading.Thread.Sleep(5000);
            Assert.IsFalse(wd.Url.Contains(URL));
           
        }
    }
}
