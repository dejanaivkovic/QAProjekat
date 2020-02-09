using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QAProjekat.Page.Objects
{
    public class HumanitySettings
    {
        public static readonly string URL = "https://kuper.humanity.com/app/admin/settings/";
        public static readonly string COUNTRY_XPath = "//select[@id='country']";
        public static readonly string DEFAULT_LANGUAGE_XPath = "//td[@class='nowrap']//select[@name='language']";
        public static readonly string TIME_FORMAT_XPath = "//select[@name='pref_24hr']";
        public static readonly string SAVE_XPath = "//button[@id='act_primary']";
        private IWebDriver wd;
        public HumanitySettings(IWebDriver wd)
        {
            this.wd = wd;
        }
        #region NavigateTo
        public HumanitySettings NavigateTo()
        {
            wd.Navigate().GoToUrl(URL);
            return this;
        }
        #endregion


        #region Country

        public IWebElement GetCountry ()
        {
            return wd.FindElement(By.XPath(COUNTRY_XPath));
        }
        public HumanitySettings SelectCountry (string data)
        {
            SelectElement country = new SelectElement(GetCountry());
            country.SelectByText(data);
            return this;
        }

        //metoda za uzimanje trenutno izabrane vrednosti za Country
        public string GetSelectedCountry()
        {
            //potreban nam je SelectElement jer GetCountry vraca IWebElement a nama je potreban selektovana opcija
            SelectElement select = new SelectElement(GetCountry());
            IWebElement selected = select.SelectedOption;
            return selected.Text;

        }
        #endregion

        #region Language
        public IWebElement GetLanguage()
        {
            return wd.FindElement(By.XPath(DEFAULT_LANGUAGE_XPath));
        }
        public HumanitySettings SelectLanguage(string data)
        {
            SelectElement country = new SelectElement(GetLanguage());
            country.SelectByText(data);
            return this;
        }
        //metoda za uzimanje trenutno izabrane vrednosti za Language
        public string GetSelectedLanguage()
        {
            //potreban nam je SelectElement jer GetLanguage vraca IWebElement a nama je potreban selektovana opcija
            SelectElement select = new SelectElement(GetLanguage());
            IWebElement selected = select.SelectedOption;
            return selected.Text;

        }
        #endregion

        #region TimeFormat
        public IWebElement GetTimeFormat()
        {
            return wd.FindElement(By.XPath(TIME_FORMAT_XPath));
        }
        public HumanitySettings SelectTimeFormat(string data)
        {
            SelectElement country = new SelectElement(GetTimeFormat());
            country.SelectByText(data);
            return this;
        }
        //metoda za uzimanje trenutno izabrane vrednosti za TimeFormat
        public string GetSelectedTimeFormat()
        {
            //potreban nam je SelectElement jer GetTimeFormat vraca IWebElement a nama je potreban selektovana opcija
            SelectElement select = new SelectElement(GetTimeFormat());
            IWebElement selected = select.SelectedOption;
            return selected.Text;

        }
        #endregion

        #region Save
        public IWebElement GetSave()
        {
            return wd.FindElement(By.XPath(SAVE_XPath));
        }
        public HumanitySettings ClickSave()
        {
            GetSave().Click();
            return this;
        }
        #endregion

        //metoda za pocetno slovo veliko ostala mala kod country
        /* static string UppercaseFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        
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
