using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAProjekat.Page.Objects
{
    public class HumanityStaff
    {
        public static readonly string URL = "vasafirma.humanity.com/app/staff/list/load/true/";
        public static readonly string ADD_EMPLOYESS_XPath = "//button[@id='act_primary']";
        public static readonly string NAME_EMPLOYESS_XPath_PART1 = "//a[contains(text(),'";//prvi deo XPath-a za klik na zaposlenog (ima ih vise)
        public static readonly string NAME_EMPLOYESS_XPath_PART2 = "')]";//drugi deo XPath-a za klik na zaposlenog
        //a[contains(text(),'Op opa')]
        //a[contains(text(),'Agent Kuper')]
        #region NavigateTo
        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }
        #endregion
        #region AddEmployess
        public static IWebElement AddEmployessButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ADD_EMPLOYESS_XPath));
        }
        public static void ClickAddEmployess (IWebDriver wd)
        {
            AddEmployessButton(wd).Click();
        }
        #endregion
        #region NameEmployess
      
        public static void ClickName(IWebDriver wd, string i)
        {
            IWebElement we = wd.FindElement(By.XPath(NAME_EMPLOYESS_XPath_PART1 + i + NAME_EMPLOYESS_XPath_PART2));
            we.Click();
            
        }

        #endregion
        /* public static void ClickNameEployess(IWebDriver wd)
       {
           IReadOnlyCollection<IWebElement> lista = wd.FindElements(By.ClassName("staff-employee"));
           foreach(IWebElement item in lista)
           {
               item.FindElement(By.Name("contains(text()"));
               item.Click();
           }

       }*/
    }
}
