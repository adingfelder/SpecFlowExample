using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    /// <summary>
    /// Summary description for DropDownBox
    /// </summary>
    [TestClass]
    public class FloatingMenu
    {
        public By ClickFloatingMenu = By.XPath("//a[contains(text(),'Floating Menu')]");
        public By MenuBar = By.XPath("//div[@id='menu']");







        public void ClickingFloatingMenu(IWebDriver driver)
        {
            driver.FindElement(ClickFloatingMenu).Click();
            //Scroll down
            var element = driver.FindElement(By.CssSelector("div.row:nth-child(2) div.large-12.columns:nth-child(2) div.example:nth-child(2) div.row:nth-child(3) div.scroll.large-10.columns.large-centered > p:nth-child(10)"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

        }
        public bool FloatingMenuMoves(IWebDriver driver)
        {
            if (!(driver.FindElement(MenuBar).GetAttribute("style") is "top: 0 px;"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }



    }

