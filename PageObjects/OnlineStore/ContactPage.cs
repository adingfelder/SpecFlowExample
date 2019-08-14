using System;
using OpenQA.Selenium;

namespace SeleniumShoppingCart.ScreenModel
{
    class ContactPage
    {

        //        private string baseURL = "http://www.automationpractice.com";

        By customerButton = By.XPath("//option[contains(text(),'Customer service')]");
        By IdContact = By.Id("id_contact");
        By contactLink = By.Id("contact-link");


        public void ClickContactPage(IWebDriver driver)
        {
            driver.FindElement(contactLink).Click();

        }

        public void ClickCustomerButton(IWebDriver driver)
        {
            driver.FindElement(customerButton).Click();
        }


        public void ClickIdContact(IWebDriver driver)
        {
            driver.FindElement(IdContact).Click();
        }


        public void enterEmail(IWebDriver driver)
        {
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();

            // todo - dont hard code email to disney???
            driver.FindElement(By.Id("email")).SendKeys("WaltDisney@Disney.com");
        }




        /*
        public void GotoURL(IWebDriver driver)
        {
            try
            {
                driver.Navigate().GoToUrl(baseURL);
                driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        */

    }
}
