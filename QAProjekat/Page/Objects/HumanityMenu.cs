using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QAProjekat.Page.Objects
{
    public class HumanityMenu
    {
        //klasa se odnosi na stranicu na koju odlazimo kada se ulogujemo, dohvata zadate elemente i vrsi akciju nad njima
        public static readonly string URL = "https://kuper.humanity.com/app/dashboard/";
        public static readonly string DASHBOARD_XPath = "//a[@id='sn_dashboard']//span[@class='primNavQtip__inner']";
        public static readonly string SHIFT_PLANNING_XPath = "//a[@id='sn_schedule']//span[@class='primNavQtip__inner']";
        public static readonly string TIME_CLOCK_XPath = "//a[@id='sn_timeclock']//span[@class='primNavQtip__inner']";
        public static readonly string LEAVE_XPath = "//a[@id='sn_requests']//span[@class='primNavQtip__inner']";
        public static readonly string TRAINING_XPath = "//a[@id='sn_training']//span[@class='primNavQtip__inner']";
        public static readonly string STAFF_XPath = "//a[@id='sn_staff']//span[@class='primNavQtip__inner']";
        public static readonly string PAYROLL_XPath = "//a[@id='sn_payroll']//span[@class='primNavQtip__inner']";
        public static readonly string REPORTS_XPath = "//a[@id='sn_reports']//span[@class='primNavQtip__inner']";
        public static readonly string SETTINGS_XPath = "//a[@id='sn_admin']//span[@class='primNavQtip__inner']";
        private IWebDriver wd;

        public HumanityMenu(IWebDriver wd)
        {
            this.wd = wd;
        }
        #region NavigateTo
        public  HumanityMenu NavigateTo()
        {
            wd.Navigate().GoToUrl(URL);
            return this;
        }
        #endregion
        #region Dashboard
        public  IWebElement DashboardButton()
        {
            return wd.FindElement(By.XPath(DASHBOARD_XPath));
        }
        public  HumanityMenu ClickDashboard()
        {
            DashboardButton().Click();
            return this;
        }
        #endregion
        #region Shift_Planning
        public  IWebElement ShiftPlanningButton()
        {
            return wd.FindElement(By.XPath(SHIFT_PLANNING_XPath));
        }
        public HumanityMenu ClickShiftPlanning()
        {
            ShiftPlanningButton().Click();
            return this;
        }
        #endregion
        #region TimeClock
        public  IWebElement TimeClockButton()
        {
            return wd.FindElement(By.XPath(TIME_CLOCK_XPath));
        }
        public HumanityMenu ClickTimeClock()
        {
            TimeClockButton().Click();
            return this;
        }
        #endregion
        #region Leave
        public  IWebElement LeaveButton()
        {
            return wd.FindElement(By.XPath(LEAVE_XPath));
        }
        public HumanityMenu ClickLeave()
        {
            LeaveButton().Click();
            return this;
        }
        #endregion
        #region Training
        public  IWebElement TrainingButton()
        {
            return wd.FindElement(By.XPath(TRAINING_XPath));
        }
        public HumanityMenu ClickTraining()
        {
            TrainingButton().Click();
            return this;
        }
        #endregion
        #region Staff
        public  IWebElement StaffButton()
        {
            return wd.FindElement(By.XPath(STAFF_XPath));
        }
        public HumanityStaff ClickStaff()
        {
            StaffButton().Click();
            return new HumanityStaff(wd);
        }
        #endregion
        #region Payroll
        public  IWebElement PayrollButton()
        {
            return wd.FindElement(By.XPath(PAYROLL_XPath));
        }
        public  HumanityMenu ClickPayroll()
        {
            PayrollButton().Click();
            return this;
        }
        #endregion
        #region Reports
        public  IWebElement ReportskButton()
        {
            return wd.FindElement(By.XPath(REPORTS_XPath));
        }
        public HumanityMenu ClickReports()
        {
            ReportskButton().Click();
            return this;
        }
        #endregion
        #region Settings
        public  IWebElement SettingsButton()
        {
            return wd.FindElement(By.XPath(SETTINGS_XPath));
        }
        public HumanitySettings ClickSettings()
        {
            SettingsButton().Click();
            return new HumanitySettings(wd);
        }
        #endregion





    }
}
