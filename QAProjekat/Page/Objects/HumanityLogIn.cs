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
        public void NavigateTo()
        {
            wd.Navigate().GoToUrl(URL);
        }
        #endregion
        #region EMAIL
        public IWebElement GetEmail()
        {
            return wd.FindElement(By.XPath(EMAIL_XPath));
        }
        public void SendEmail(string data)
        {
            GetEmail().SendKeys(data);
        }
        #endregion
        #region PASS
        public IWebElement GetPass()
        {
            return wd.FindElement(By.XPath(PASS_XPath));
        }
        public void SendPass(string data)
        {
            GetPass().SendKeys(data);
        }
        #endregion
        #region LogIn
        public IWebElement LoginButton()
        {
            return wd.FindElement(By.XPath(LOGIN_XPath));
        }
        public void ClickLogin()
        {
            LoginButton().Click();
        }
        #endregion

    }
}
