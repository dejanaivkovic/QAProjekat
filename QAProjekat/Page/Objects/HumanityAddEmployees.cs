using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace QAProjekat.Page.Objects
{
    public class HumanityAddEmployees
    {
        public static readonly string URL = "vasafirma.humanity.com/app/staff/list/load/true/";
        public static readonly string ADD_EMPLOYESS_XPath = "//button[@id='act_primary']";
        public static readonly string NAME_PART1_XPath = "//input[@id='_asf";//prvi deo XPath-a za name elemenat (imamo ih vise)
        public static readonly string LAST_NAME_PART1_XPath = "//input[@id='_asl"; //prvi deo XPath-a za last name elemenat
        public static readonly string EMAIL_PART1_XPath = "//input[@id='_ase";//prvi deo za XPath-a za email
        public static readonly string PART2_XPath = "']";//drugi deo XPath-a za elemente (name, last name, email)
        public static readonly string SAVE_BUTTON_XPath = "//button[@id='_as_save_multiple']";
        

        #region AddEmployess
        public static IWebElement AddEmployessButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ADD_EMPLOYESS_XPath));
        }
        public static void ClickAddEmployess(IWebDriver wd)
        {
            AddEmployessButton(wd).Click();
        }
        #endregion
        #region Name
        public static IWebElement GetName(IWebDriver wd, int i)
        {
            return wd.FindElement(By.XPath(NAME_PART1_XPath + i + PART2_XPath));
        }
        public static void SendName (IWebDriver wd, string firstName, int i)
        {
            GetName(wd, i).SendKeys(firstName);
        }
        #endregion
        #region LastName
        public static IWebElement GetLastName(IWebDriver wd, int i)
        {
            return wd.FindElement(By.XPath(LAST_NAME_PART1_XPath + i + PART2_XPath));
        }
        public static void SendLastName (IWebDriver wd, string lastName, int i)
        {
            GetLastName(wd, i).SendKeys(lastName);
        }
        #endregion
        #region EMAIL
        public static IWebElement GetEmail(IWebDriver wd, int i)
        {
            return wd.FindElement(By.XPath(EMAIL_PART1_XPath + i + PART2_XPath));
        }
        public static void SendEmail(IWebDriver wd, string email, int i)
        {
            GetEmail(wd, i).SendKeys(email);
        }
        #endregion
        #region SaveButton
        public static IWebElement GetSave(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SAVE_BUTTON_XPath));
        }
        public static void ClickSave (IWebDriver wd)
        {
            GetSave(wd).Click();
        }
        #endregion
       
       


    }
}
