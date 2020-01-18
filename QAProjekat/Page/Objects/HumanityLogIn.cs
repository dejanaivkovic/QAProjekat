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
        #region NavigateTO
        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }
        #endregion
        #region EMAIL
        public static IWebElement GetEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EMAIL_XPath));
        }
        public static void SendEmail(IWebDriver wd, string data)
        {
            GetEmail(wd).SendKeys(data);
        }
        #endregion
        #region PASS
        public static IWebElement GetPass(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(PASS_XPath));
        }
        public static void SendPass(IWebDriver wd, string data)
        {
            GetPass(wd).SendKeys(data);
        }
        #endregion
        #region LogIn
        public static IWebElement LoginButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(LOGIN_XPath));
        }
        public static void ClickLogin(IWebDriver wd)
        {
            LoginButton(wd).Click();
        }
        #endregion

    }
}
