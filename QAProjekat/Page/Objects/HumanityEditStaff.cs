using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace QAProjekat.Page.Objects
{
    public class HumanityEditStaff
    {
        //koja omogućava da se doda slika na profil i promeni nickname, a zatim da se postavljena podešavanja sačuvaju
        //preko linka Staff dolazis do nje kad se klikne na zaposlenog
        public static readonly string EDIT_DETAILS_XPath = "//a[contains(text(),'Edit Details')]";
        public static readonly string UPLOAD_PICTURE_XPath = "//input[@id='fileupload']";
        public static readonly string NICK_NAME_XPath = "//input[@id='nick_name']";
        public static readonly string SAVE_BUTTON_XPath = "//button[@id='act_primary']";
        #region EditDetails
        public static IWebElement GetEditDetails (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EDIT_DETAILS_XPath));
        }
        public static void ClickGetEditDetails (IWebDriver wd)
        {
            GetEditDetails(wd).Click();
        }
        #endregion
        #region UploadPicture
        public static IWebElement GetUploadPicture(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(UPLOAD_PICTURE_XPath));
        }
        public static void ClickUploadPicture(IWebDriver wd)
        {
            GetUploadPicture(wd).Click();
        }
        #endregion
        #region NickName
        public static IWebElement GetNickName (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(NICK_NAME_XPath));
        }
        public static void SendNickName (IWebDriver wd, string data)
        {
            GetNickName(wd).SendKeys(data);
        }
        #endregion
        #region SaveButton
        public static IWebElement GetSaveButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SAVE_BUTTON_XPath));
        }
        public static void ClickSaveButton(IWebDriver wd)
        {
            GetSaveButton(wd).Click();
        }
        #endregion
    }
}
