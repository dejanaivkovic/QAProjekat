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


        private IWebDriver wd;

        public HumanityHome(IWebDriver wd)
        {
            this.wd = wd;
        }

        #region NavigateTO
        public HumanityHome NavigateTo()
        {
            wd.Navigate().GoToUrl(URL);
            return this;

        }
        #endregion


        #region RegisterButton1
        public IWebElement RegisterButton1 ()
        {
            return wd.FindElement(By.XPath(START_FREE_TRIAL_BUTTON_XPath));
        }
        public HumanityHome ClickRegister1()
        {
            RegisterButton1().Click();
            return this;
        }
        #endregion
        #region LoginButton
        public IWebElement LoginButton()
        {
            return wd.FindElement(By.XPath(LOGIN_BUTTON_XPath));
        }
        public HumanityLogIn ClickLogin()
        {
            LoginButton().Click();
            return new HumanityLogIn(wd);
        }
        #endregion
        #region AboutUs
        public IWebElement AboutUsButton()
        {
            return wd.FindElement(By.XPath(ABOUT_US_XPath));
        }
        public HumanityHome ClickAboutUs()
        {
            LoginButton().Click();
            return this;
        }
        #endregion
        #region FullName
        public IWebElement GetFullName ()
        {
            return wd.FindElement(By.XPath(FULL_NAME_XPath));
        }
        public HumanityHome SendFullName (string data)
        {
            GetFullName().SendKeys(data);
            return this;
        }
        #endregion

        #region WorkEmail
        public  IWebElement GetWorkEmail()
        {
            return wd.FindElement(By.XPath(WORK_EMAIL_XPath));
        }
        public  HumanityHome SendWorkEmail(string data)
        {
            GetWorkEmail().SendKeys(data);
            return this;
        }
        #endregion
        #region Cookies
        public  IWebElement CookiesButton()
        {
            return wd.FindElement(By.XPath(COOKIES_XPath));
        }
        public  void ClickCookies()
        {
            CookiesButton().Click();
        }
        #endregion
        #region RegisterButton2
        public  IWebElement RegisterButton2()
        {
            return wd.FindElement(By.XPath(START_FREE_TRIAL_BUTTON2_XPath));
        }
        public  HumanityHome ClickRegister2()
        {
            RegisterButton2().Click();
            return this;
        }

        #endregion

    }
}
