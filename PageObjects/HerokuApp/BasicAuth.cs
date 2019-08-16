using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    class BasicAuth
    {
        public By button = By.LinkText("Basic Auth");
        



        public void GoToBasicAuth(IWebDriver driver)
        {
            driver.FindElement(button).Click();
        }

        
    }
}
