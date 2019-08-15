using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    class ContextMenu
    {
        public By blackBox = By.Id("hot-spot");
        public By contextMenu = By.XPath("//a[contains(text(),'Context Menu')]");
        
        
        //Method to click the button 
        public void GoToContextMenu(IWebDriver driver)
        {
            driver.FindElement(contextMenu).Click();
        }

        //Method for right click
        public void RightClickObBox(IWebDriver driver)
        {
            Actions rightClickAction = new Actions(driver);
            rightClickAction.ContextClick(driver.FindElement(blackBox)).Perform();
        }

        

    }
}
