using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAProjekat.Page.Objects
{
    public class HumanityStaff
    {
        public static readonly string URL = "https://kuper.humanity.com/app/staff/list/load/true/";
        public static readonly string ADD_EMPLOYESS_XPath = "//button[@id='act_primary']";
        public static readonly string NAME_EMPLOYESS_XPath_PART1 = "//a[contains(text(),'";//prvi deo XPath-a za klik na zaposlenog (ima ih vise)
        public static readonly string NAME_EMPLOYESS_XPath_PART2 = "')]";//drugi deo XPath-a za klik na zaposlenog
        //a[contains(text(),'Op opa')]
        //a[contains(text(),'Agent Kuper')]
        private IWebDriver wd;
        public HumanityStaff(IWebDriver wd)
        {
            this.wd = wd;
        }
        #region NavigateTo
        public HumanityStaff NavigateTo()
        {
            wd.Navigate().GoToUrl(URL);
            return this;
        }
        #endregion
        #region AddEmployess
        public  IWebElement AddEmployessButton()
        {
            return wd.FindElement(By.XPath(ADD_EMPLOYESS_XPath));
        }
        public HumanityAddEmployees ClickAddEmployess ()
        {
            AddEmployessButton().Click();
            return new HumanityAddEmployees(wd);
        }
        #endregion
        #region NameEmployess
      
       
        public IWebElement  GetByName(string i)
        {
            return wd.FindElement(By.XPath(NAME_EMPLOYESS_XPath_PART1 + i + NAME_EMPLOYESS_XPath_PART2));
           
        }
        public HumanityEditStaff ClickName(string i)
        {
            GetByName(i).Click();
            return new HumanityEditStaff(wd);
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
