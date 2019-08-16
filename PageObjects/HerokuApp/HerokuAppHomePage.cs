using System;
using OpenQA.Selenium;

namespace HerokuApp.ScreenModel
{

    class HerokuAppHomePage
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /*
        private By SignInButtonHomePage = By.LinkText("Sign in");
        private By EmailTextBoxOnHomePage = By.Id("email");
        private By PasswordTextBoxOnHomePage = By.Id("passwd");
        private By SignInSubmitButon = By.Id("SubmitLogin");
        private string testEmail = "seleniumtraining@gmail.com";
        */

        private string baseURL = "http://the-internet.herokuapp.com";
        

        public void GotoURL(IWebDriver driver)
        {
            log.Info("HomePage going to URL: "+ baseURL);
            try {
                driver.Navigate().GoToUrl(baseURL);
                driver.Manage().Window.Maximize();
            } catch (Exception e) {
                log.Error("Error in HomePage going to URL: " + baseURL, e);
            }
        }


        /*
        public void ClickSignIn(IWebDriver driver)
        {
            log.Debug("HomePage clicking sign in button");
            driver.FindElement(SignInButtonHomePage).Click();
        }
        public void EnterEmail(IWebDriver driver)
        {
            driver.FindElement(EmailTextBoxOnHomePage).Click();
            driver.FindElement(EmailTextBoxOnHomePage).Clear();
            driver.FindElement(EmailTextBoxOnHomePage).SendKeys(testEmail);
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

    */
    }
}
