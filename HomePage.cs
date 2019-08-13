using System;
using OpenQA.Selenium;

namespace SeleniunUsingCSharpAndNunit.ScreenModel
{
    class HomePage
    {
        private By SignInButtonHomePage = By.LinkText("Sign in");
        private By EmailTextBoxOnHomePage = By.Id("email");
        private By PasswordTextBoxOnHomePage = By.Id("passwd");
        private By SignInSubmitButon = By.Id("SubmitLogin");

        public void GotoURL(IWebDriver driver)
        {
            try
            {
                driver.Navigate().GoToUrl("http://www.automationpractice.com");
                driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ClickSignIn(IWebDriver driver)
        {
            driver.FindElement(SignInButtonHomePage).Click();
        }
        public void EnterEmail(IWebDriver driver)
        {
            driver.FindElement(EmailTextBoxOnHomePage).Click();
            driver.FindElement(EmailTextBoxOnHomePage).Clear();
            driver.FindElement(EmailTextBoxOnHomePage).SendKeys("seleniumtraining@gmail.com");
        }

        public void EnterPassword(IWebDriver driver)
        {
            driver.FindElement(PasswordTextBoxOnHomePage).Clear();
            driver.FindElement(PasswordTextBoxOnHomePage).SendKeys("planit123");
        }

        public void ClickSignInButton(IWebDriver driver)
        {
            driver.FindElement(SignInSubmitButon).Click();
        }
    }
}
