using System;
using OpenQA.Selenium;

namespace SeleniumShoppingCart.ScreenModel
{
    class WishList
    {

        /*public By TShirtsTab = By.XPath("//body[@id='index']/div[@id='page']/div[@class='header-container']/header[@id='header']/div/div[@class='container']/div[@class='row']/div[@id='block_top_menu']/ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li[3]/a[1]");
         public By MoreTab = By.XPath("//*[@id=\"center_column\"]/ul/li/div/div[2]/h5/a");
         public By AddShirt = By.XPath("//a[@class='btn btn-default button-plus product_quantity_up']");
         public By ChangeSize = By.XPath("//select[@id='group_1']");
         public By ChangingSize = By.XPath("//div[@id='uniform-group_1']");
         public By PickM = By.XPath("//option[contains(text(),'M')]");
         public By ChangeColour = By.XPath("//a[@id='color_14']");
         public By AddCart = By.XPath("//*[@id=\"add_to_cart\"]/button/span"); */



        public By DressTab = By.XPath("//body[@id='my-account']/div[@id='page']/div[@class='header-container']/header[@id='header']/div/div[@class='container']/div[@class='row']/div[@id='block_top_menu']/ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li[2]/a[1]");
        public By SelectDress = By.XPath("//li[@class='ajax_block_product col-xs-12 col-sm-6 col-md-4 last-item-of-tablet-line']//a[@class='product-name'][contains(text(),'Printed Dress')]");
        public By PressWishList = By.Id("wishlist_button");





        public void ClickDressTab(IWebDriver driver)
        {
            driver.FindElement(DressTab).Click();

        }

        public void SelectDressTab(IWebDriver driver)
        {
            driver.FindElement(SelectDress).Click();
        }


        public void WishListButton(IWebDriver driver)
        {
            driver.FindElement(PressWishList).Click();
        }




    }
}


