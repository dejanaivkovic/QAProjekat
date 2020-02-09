using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace QAProjekat.Page.Objects
{
    public class HumanityAddEmployees
    {
        public static readonly string URL = "kuper.humanity.com/app/staff/list/load/true/";
        public static readonly string ADD_EMPLOYESS_XPath = "//button[@id='act_primary']";
        public static readonly string NAME_PART1_XPath = "//input[@id='_asf";//prvi deo XPath-a za name elemenat (imamo ih vise)
        public static readonly string LAST_NAME_PART1_XPath = "//input[@id='_asl"; //prvi deo XPath-a za last name elemenat
        public static readonly string EMAIL_PART1_XPath = "//input[@id='_ase";//prvi deo za XPath-a za email
        public static readonly string PART2_XPath = "']";//drugi deo XPath-a za elemente (name, last name, email)
        public static readonly string SAVE_BUTTON_XPath = "//button[@id='_as_save_multiple']";
        private IWebDriver wd;
        public HumanityAddEmployees (IWebDriver wd)
        {
            this.wd = wd;
        }
        public HumanityAddEmployees NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
            return this;
        }

        #region AddEmployess
        public  IWebElement AddEmployessButton()
        {
            return wd.FindElement(By.XPath(ADD_EMPLOYESS_XPath));
        }
        public HumanityAddEmployees ClickAddEmployess()
        {
            AddEmployessButton().Click();
            return this;
        }
        #endregion
        #region Name
        public  IWebElement GetName(int i)
        {
            return wd.FindElement(By.XPath(NAME_PART1_XPath + i + PART2_XPath));
        }
        public HumanityAddEmployees SendName (string firstName, int i)
        {
            GetName(i).SendKeys(firstName);
            return this;

        }
        #endregion
        #region LastName
        public  IWebElement GetLastName(int i)
        {
            return wd.FindElement(By.XPath(LAST_NAME_PART1_XPath + i + PART2_XPath));
        }
        public HumanityAddEmployees SendLastName (string lastName, int i)
        {
            GetLastName(i).SendKeys(lastName);
            return this;

        }
        #endregion
        #region EMAIL
        public IWebElement GetEmail(int i)
        {
            return wd.FindElement(By.XPath(EMAIL_PART1_XPath + i + PART2_XPath));
        }
        public HumanityAddEmployees SendEmail(string email, int i)
        {
            GetEmail(i).SendKeys(email);
            return this;
        }
        #endregion
        #region SaveButton
        public IWebElement GetSave()
        {
            return wd.FindElement(By.XPath(SAVE_BUTTON_XPath));
        }
        public HumanityAddEmployees ClickSave ()
        {
            GetSave().Click();
            return this;
        }
        #endregion
       
       


    }
}
