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
        #region NavigateTo
        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }
        #endregion
        #region Dashboard
        public static IWebElement DashboardButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(DASHBOARD_XPath));
        }
        public static void ClickDashboard(IWebDriver wd)
        {
            DashboardButton(wd).Click();
        }
        #endregion
        #region Shift_Planning
        public static IWebElement ShiftPlanningButton (IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SHIFT_PLANNING_XPath));
        }
        public static void ClickShiftPlanning(IWebDriver wd)
        {
            ShiftPlanningButton(wd).Click();
        }
        #endregion
        #region TimeClock
        public static IWebElement TimeClockButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TIME_CLOCK_XPath));
        }
        public static void ClickTimeClock(IWebDriver wd)
        {
            TimeClockButton(wd).Click();
        }
        #endregion
        #region Leave
        public static IWebElement LeaveButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(LEAVE_XPath));
        }
        public static void ClickLeave(IWebDriver wd)
        {
            LeaveButton(wd).Click();
        }
        #endregion
        #region Training
        public static IWebElement TrainingButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TRAINING_XPath));
        }
        public static void ClickTraining(IWebDriver wd)
        {
            TrainingButton(wd).Click();
        }
        #endregion
        #region Staff
        public static IWebElement StaffButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(STAFF_XPath));
        }
        public static void ClickStaff(IWebDriver wd)
        {
            StaffButton(wd).Click();
        }
        #endregion
        #region Payroll
        public static IWebElement PayrollButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(PAYROLL_XPath));
        }
        public static void ClickPayroll(IWebDriver wd)
        {
            PayrollButton(wd).Click();
        }
        #endregion
        #region Reports
        public static IWebElement ReportskButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(REPORTS_XPath));
        }
        public static void ClickReports(IWebDriver wd)
        {
            ReportskButton(wd).Click();
        }
        #endregion
        #region Settings
        public static IWebElement SettingsButton(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SETTINGS_XPath));
        }
        public static void ClickSettings(IWebDriver wd)
        {
            SettingsButton(wd).Click();
        }
        #endregion





    }
}
