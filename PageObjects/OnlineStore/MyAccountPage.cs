using OpenQA.Selenium;

namespace SeleniumShoppingCart.ScreenModel
{
    class MyAccountPage
    {
        private By accountNameOnMyAccountPage = By.CssSelector("span");
        //private By RegisterNameOnAccountPage = By.XPath("//a[@class='account']");
       
        

        public string getAccountName(IWebDriver driver)
        {
            string getLoginUserName = driver.FindElement(accountNameOnMyAccountPage).Text;
              
            return getLoginUserName;
        }

        //public string getRegisterName(IWebDriver driver)
        //{
        //    string getRegisterName = driver.FindElement(RegisterNameOnAccountPage).Text;
        //    return getRegisterName;
        //}
        
    }
}

