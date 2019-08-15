using System;
using OpenQA.Selenium;

namespace SeleniumShoppingCart.ScreenModel
{
    class TShirtsDetails
    {

        public By TShirtsTab = By.XPath("//body[@id='index']/div[@id='page']/div[@class='header-container']/header[@id='header']/div/div[@class='container']/div[@class='row']/div[@id='block_top_menu']/ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li[3]/a[1]");
        public By MoreTab = By.XPath("//*[@id=\"center_column\"]/ul/li/div/div[2]/h5/a");
        public By AddShirt = By.XPath("//a[@class='btn btn-default button-plus product_quantity_up']");
        public By ChangeSize = By.XPath("//select[@id='group_1']");
        public By ChangingSize = By.XPath("//div[@id='uniform-group_1']");
        public By PickM = By.XPath("//option[contains(text(),'M')]");
        public By ChangeColour = By.XPath("//a[@id='color_14']");
        public By AddCart = By.XPath("//*[@id=\"add_to_cart\"]/button/span");


        public void ClickTShirtsTab(IWebDriver driver)
        {
            driver.FindElement(TShirtsTab).Click();

        }

        public void ClickMoreButton(IWebDriver driver)
        {
            driver.FindElement(MoreTab).Click();
        }


        public void AddAShirt(IWebDriver driver)
        {
            driver.FindElement(AddShirt).Click();
        }

        public void FindSizeTab(IWebDriver driver)
        {
            driver.FindElement(ChangeSize).Click();
        }
        public void PickSize(IWebDriver driver)
        {
            driver.FindElement(ChangingSize).Click();
        }
        public void PickMSize(IWebDriver driver)
        {
            driver.FindElement(PickM).Click();
        }
        public void PickBlueColour(IWebDriver driver)
        {
            driver.FindElement(ChangeColour).Click();
        }
        public void AddToCart(IWebDriver driver)
        {
            driver.FindElement(AddCart).Click();
        }



    }
}


