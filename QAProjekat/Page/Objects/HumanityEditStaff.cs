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
        public static readonly string FILE_UPLOAD_ID = "fileupload";
        public static readonly string PROFILE_IMG_Xpath = "//img[contains(@id, 'userAvatar')]";
        private IWebDriver wd;
        public HumanityEditStaff (IWebDriver wd)
        {
            this.wd = wd;
        }
        #region EditDetails
        public  IWebElement GetEditDetails ()
        {
            return wd.FindElement(By.XPath(EDIT_DETAILS_XPath));
        }
        public HumanityEditStaff ClickGetEditDetails ()
        {
            GetEditDetails().Click();
            return this;
        }
        #endregion
        #region UploadPicture
        public IWebElement GetUploadPicture()
        {
            return wd.FindElement(By.XPath(UPLOAD_PICTURE_XPath));
        }
        public HumanityEditStaff ClickUploadPicture()
        {
            GetUploadPicture().Click();
            return this;
        }
        #endregion
        #region NickName
        public IWebElement GetNickName ()
        {
            return wd.FindElement(By.XPath(NICK_NAME_XPath));
        }
        public HumanityEditStaff SendNickName (string data)
        {
            GetNickName().SendKeys(data);
            return this;
        }
        #endregion
        #region SaveButton
        public  IWebElement GetSaveButton()
        {
            return wd.FindElement(By.XPath(SAVE_BUTTON_XPath));
        }
        public HumanityEditStaff ClickSaveButton()
        {
            GetSaveButton().Click();
            return this;
        }
        #endregion
        #region UploadPicture
        //metoda za upload picture da bi mogli da testiramo da li se slika promenila
        public HumanityEditStaff UploadPicture(string picture_path)
        {
            IWebElement uploadPicture = wd.FindElement(By.Id(FILE_UPLOAD_ID));
            uploadPicture.SendKeys(picture_path);
            return this;
        }
        #endregion
        #region ProfilePictureURL
        public string ProfilePictureURL()
        {
            IWebElement img = wd.FindElement(By.XPath(PROFILE_IMG_Xpath));
            string src = img.GetAttribute("src");
            return src;

        }
        #endregion

    }
}
