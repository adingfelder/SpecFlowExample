using OpenQA.Selenium;

namespace SeleniumShoppingCart.ScreenModel
{
    class MyAccountPage
    {
        private By accountNameOnMyAccountPage = By.CssSelector("span");
       
       
        

        public string getAccountName(IWebDriver driver)
        {
            string getLoginUserName = driver.FindElement(accountNameOnMyAccountPage).Text;
              
            return getLoginUserName;
        }

        

    }
}

