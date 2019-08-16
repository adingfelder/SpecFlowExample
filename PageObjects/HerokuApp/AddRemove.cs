using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    /// <summary>
    /// </summary>
    [TestClass]
    public class AddRemove
    {
        public By Click = By.XPath("//a[contains(text(),'Add/Remove Elements')]");
        public By Add = By.XPath("//button[contains(text(),'Add Element')]");
        public By Delete = By.XPath("//button[@class='added-manually']");







        public void ClickingButton(IWebDriver driver)
        {
            driver.FindElement(Click).Click();

        }

        public void AddElement(IWebDriver driver)
        {
            driver.FindElement(Add).Click();
            
        }
        public void RemoveElement(IWebDriver driver)
        {
            driver.FindElement(Delete).Click();
        }



    }
}
