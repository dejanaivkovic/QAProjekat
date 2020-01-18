using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace QAProjekat.Page.Objects
{
    public class HumanityHome
    {
        //klasa se odnosi na pocetnu stranu sajta Humanity, dohvata elemente koji su zadati i vrsi akciju nad njima
        public static readonly string URL = "https://www.humanity.com/";
        public static readonly string START_FREE_TRIAL_BUTTON_XPath = "//a[@class='button pale']";
        public static readonly string LOGIN_BUTTON_XPath = "//p[contains(text(),'LOGIN')]";
        public static readonly string ABOUT_US_XPath = "//a[@class='nav-link no-before'][contains(text(),'About us')]";
        public static readonly string FULL_NAME_XPath = "//div[@class='input-wrapper']//input[@placeholder='Full Name']";
        public static readonly string WORK_EMAIL_XPath = "//div[@class='input-wrapper']//input[@placeholder='Work Email']";
        public static readonly string START_FREE_TRIAL_BUTTON2_XPath = "//input[@id='free-trial-link-01']";
        //ova promenljiva postoji jer je na mom racunaru manja rezolucija pa informcija"accept cookies" prelazi preko dugmeta
        //a mora celo dugme da bude vidljivo da bi se kliknulo na njega
        public static readonly string COOKIES_XPath = "//a[@class='cc-btn cc-dismiss']";
        #region NavigateTO
        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }
        #endregion


        #region RegisterButton1
        public static IWebElement RegisterButton1 (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(START_FREE_TRIAL_BUTTON_XPath));
        }
        public static void ClickRegister1(IWebDriver wd)
        {
            RegisterButton1(wd).Click();
        }
        #endregion
        #region LoginButton
        public static IWebElement LoginButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(LOGIN_BUTTON_XPath));
        }
        public static void ClickLogin(IWebDriver wd)
        {
            LoginButton(wd).Click();
        }
        #endregion
        #region AboutUs
        public static IWebElement AboutUsButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ABOUT_US_XPath));
        }
        public static void ClickAboutUs(IWebDriver wd)
        {
            LoginButton(wd).Click();
        }
        #endregion
        #region FullName
        public static IWebElement GetFullName (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(FULL_NAME_XPath));
        }
        public static void SendFullName (IWebDriver wd, string data)
        {
            GetFullName(wd).SendKeys(data);
        }
        #endregion

        #region WorkEmail
        public static IWebElement GetWorkEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(WORK_EMAIL_XPath));
        }
        public static void SendWorkEmail(IWebDriver wd, string data)
        {
            GetWorkEmail(wd).SendKeys(data);
        }
        #endregion
        #region Cookies
        public static IWebElement CookiesButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(COOKIES_XPath));
        }
        public static void ClickCookies(IWebDriver wd)
        {
            CookiesButton(wd).Click();
        }
        #endregion
        #region RegisterButton2
        public static IWebElement RegisterButton2(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(START_FREE_TRIAL_BUTTON2_XPath));
        }
        public static void ClickRegister2(IWebDriver wd)
        {
            RegisterButton2(wd).Click();
        }

        #endregion

    }
}
