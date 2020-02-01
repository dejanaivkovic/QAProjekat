using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
namespace QAProjekat.Page.Objects
{
    public class HumanityLogIn
    {
        //klasa se odnosi na stranicu koju dobijamo kada zelimo da se ulogujemo, 
        //dohvata potrebne elemente za uspesno login-ovanje i vrsi akcije nad njima 
        public static readonly string URL = "https://www.humanity.com/app/";
        public static readonly string EMAIL_XPath = "//input[@id='email']";
        public static readonly string PASS_XPath = "//input[@id='password']";
        public static readonly string LOGIN_XPath = "//button[@name='login'][contains(text(),'Log in')]";

        private IWebDriver wd;
        public HumanityLogIn(IWebDriver wd)
        {
            this.wd = wd;
        }

        #region NavigateTO
        //umesto void stavljeno vracamo isti objekat da mozemo da vezemo pozive
        public HumanityLogIn NavigateTo()
        {
            wd.Navigate().GoToUrl(URL);
            return this;
        }
        #endregion
        #region EMAIL
        public IWebElement GetEmail()
        {
            return wd.FindElement(By.XPath(EMAIL_XPath));
        }
        public HumanityLogIn SendEmail(string data)
        {
            GetEmail().SendKeys(data);
            return this;
        }
        #endregion
        #region PASS
        public IWebElement GetPass()
        {
            return wd.FindElement(By.XPath(PASS_XPath));
        }
        public HumanityLogIn SendPass(string data)
        {
            GetPass().SendKeys(data);
            return this;
        }
        #endregion
        #region LogIn
        public IWebElement LoginButton()
        {
            return wd.FindElement(By.XPath(LOGIN_XPath));
        }
        public HumanityHome ClickLogin()
        {
            LoginButton().Click();
            return new HumanityHome(wd);
        }
        #endregion

    }
}
