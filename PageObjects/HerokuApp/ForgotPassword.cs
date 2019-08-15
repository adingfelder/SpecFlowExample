using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    /// <summary>
    /// Summary description for DropDownBox
    /// </summary>
    [TestClass]
    public class ForgotPassword
    {
        public By SelectForgotPassword = By.XPath("//a[contains(text(),'Forgot Password')]");
        public By EnterEmail = By.Id("email");
        string Email = "hi123@gmail.com";
        public By Retrieve = By.XPath("//i[@class='icon-2x icon-signin']");







        public void SelectingForgotPassword(IWebDriver driver)
        {
            driver.FindElement(SelectForgotPassword).Click();

        }

        public void EnteringEmail(IWebDriver driver)
        {
            driver.FindElement(EnterEmail).Click();
            //return Email;
            driver.FindElement(EnterEmail).SendKeys(Email);
        }
        public void RetrievePassword(IWebDriver driver)
        {
            driver.FindElement(Retrieve).Click();
        } 



    }
}
