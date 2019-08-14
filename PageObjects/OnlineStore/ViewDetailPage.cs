using OpenQA.Selenium;

namespace SeleniumShoppingCart.ScreenModel
{
    class ViewDetailPage
    {
        //private By FirstMoreButton = By.XPath("//li[@class='ajax_block_product col-xs-12 col-sm-4 col-md-3 first-in-line first-item-of-tablet-line first-item-of-mobile-line hovered']//span[contains(text(),'More')]");
        private By targetName = By.XPath("//div[@id='short_description_content']//p[contains(text(),'Faded short sleeve t-shirt with high neckline. Sof')]");
      

        private By ProductName = By.LinkText("Faded Short Sleeve T-shirts");

        public void ClickMore(IWebDriver driver)
        {
            driver.FindElement(ProductName).Click();
        }

        public string GetItemDetail(IWebDriver driver)
        {
            string getDetailString = driver.FindElement(targetName).Text;
            return getDetailString;
        } 



    }
}
