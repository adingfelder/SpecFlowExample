using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    

    class InputNumber
    {
        public By _button = By.LinkText("Inputs");
        public By _textfield = By.XPath("//div[@class='example']//input");

        public void GoToPage(IWebDriver driver)
        {
            driver. FindElement(_button).Click();
        }
        public void Select(IWebDriver driver)
        {
            IWebElement textbox = driver.FindElement(_textfield);
            textbox.SendKeys(Keys.ArrowDown);
            Task.Delay(3000).Wait();
           
        }
    }
}
