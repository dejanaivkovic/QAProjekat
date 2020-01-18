using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QAProjekat.Page.Objects
{
    public class HumanitySettings
    {
        public static readonly string COUNTRY_XPath = "//select[@id='country']";
        public static readonly string DEFAULT_LANGUAGE_XPath = "//td[@class='nowrap']//select[@name='language']";
        public static readonly string TIME_FORMAT_XPath = "//select[@name='pref_24hr']";
        #region Country
        public static IWebElement GetCountry (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(COUNTRY_XPath));
        }
        public static void SelectCountry (IWebDriver wd, string data)
        {
            SelectElement country = new SelectElement(GetCountry(wd));
            country.SelectByText(data);
        }
        #endregion

        #region Language
        public static IWebElement GetLanguage(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(DEFAULT_LANGUAGE_XPath));
        }
        public static void SelectLanguage(IWebDriver wd, string data)
        {
            SelectElement country = new SelectElement(GetLanguage(wd));
            country.SelectByText(data);
        }
        #endregion

        #region TimeFormat
        public static IWebElement GetTimeFormat(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TIME_FORMAT_XPath));
        }
        public static void SelectTimeFormat(IWebDriver wd, string data)
        {
            SelectElement country = new SelectElement(GetCountry(wd));
            country.SelectByText(data);
        }
        #endregion
        //metoda za pocetno slovo veliko ostala mala kod country
        static string UppercaseFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        /*
        //metoda za svako novo pocetno slovo da je veliko kod language
        static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        */
    }

}
