using OpenQA.Selenium;

namespace SeleniumShoppingCart.ScreenModel
{
    class InCartChecker
    {
        public string InCartCheck(IWebDriver driver, string cartItemName)
        {
            By targetDescription = By.XPath("//td[@class='cart_description']//a[contains(text(),'" + cartItemName + "')]");
            string cartString = driver.FindElement(targetDescription).Text;


            return cartString;
        }



    }
}
