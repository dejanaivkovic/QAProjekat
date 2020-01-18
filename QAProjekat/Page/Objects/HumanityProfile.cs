using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QAProjekat.Page.Objects
{
    public class HumanityProfile
    {
        //klasa za podesavanje profila
        public static readonly string PROFILE_ICON_XPath = "//div[@id='wrap_us_menu']";
        public static readonly string PROFILE_XPath = "//a[contains(text(),'Profile')]";
        public static readonly string SETTINGS_XPath = "//div[@class='userm userm-mainPage']//a[contains(text(),'Settings')]";
        public static readonly string AVAILABILITY_XPath = "//div[@class='userm userm-mainPage']//a[contains(text(),'Availability')]";
        public static readonly string VERSION_XPath = "//b[contains(text(),'9.13.4')]";
        #region ProfileIcon
        public static IWebElement GetProfileIcon (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(PROFILE_ICON_XPath));
        }
        public static void ClickProfileIcon (IWebDriver wd)
        {
            GetProfileIcon(wd).Click();
        }
        #endregion
        #region Profile
        public static IWebElement GetProfile (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(PROFILE_XPath));
        }
        public static void ClickProfile (IWebDriver wd)
        {
            GetProfile(wd).Click();
        }
        #endregion
        #region Settings
        public static IWebElement GetSettings (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SETTINGS_XPath));
        }
        public static void ClickSettings (IWebDriver wd)
        {
            GetSettings(wd).Click();
        }
        #endregion
        #region Availability
        public static IWebElement GetAvailability(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AVAILABILITY_XPath));
        }
        public static void ClickAvailability(IWebDriver wd)
        {
            GetAvailability(wd).Click();
        }
        #endregion
        #region Version
        //dohvatamo verziju preko ID i ispisujemo je u konzoli
        public static IWebElement GetVersion (IWebDriver wd)
        {
            IWebElement we;
            we = wd.FindElement(By.Id("humanityAppVersion"));
            return we.FindElement(By.TagName("b"));
           
        }
        public static void SendVersion (IWebDriver wd)
        {
            Console.WriteLine(GetVersion(wd).Text);
           
        }
        #endregion
    }
}
