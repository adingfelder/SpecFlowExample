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
    public class DropDownBox
    {
        public By SelectDropdown = By.Id("dropdown");
        public By OptionTwo = By.XPath("//option[contains(text(),'Option 2')]");
        public By Click = By.XPath("//*[@id=\"content\"]/ul/li[11]/a");
        
        public void SelectingDropdown(IWebDriver driver)
        {
            driver.FindElement(SelectDropdown).Click();
        }

        public void SelectOptionTwo(IWebDriver driver)
        {
            driver.FindElement(OptionTwo).Click();
        }
        public void ClickDropDown(IWebDriver driver)
        {
            driver.FindElement(Click).Click();
        }
    }
}
