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
        public By LinkText = By.LinkText("Context Menu");
        public By contextMenu = By.XPath("//h3[contains(text(),'Context Menu')]");
        
        
        
        //Method to click the button 
        public void GoToContextMenu(IWebDriver driver)
        {
            driver.FindElement(LinkText).Click();
        }

        //Method for right click
        public void RightClickObBox(IWebDriver driver)
        {
            Actions rightClickAction = new Actions(driver);
            rightClickAction.ContextClick(driver.FindElement(blackBox)).Perform();
        }
        public void ClickBlankSpace(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("example")).Click();
        }

        //return the word "contextMenu"
        public string ContextMenuText(IWebDriver driver)
        {
            string target = driver.FindElement(contextMenu).Text;
            return target;
        }
        

    }
}
