using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // For debugging - Should be removed - No sleeps should be in the code
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace SeleniumShoppingCart
{
    [TestFixture]
    public class SearchTShirts
    {
        private IWebDriver driver;
        public string homeURL;


        [Test]
        public void Login_is_on_home_page()
        {


            homeURL = "http://automationpractice.com/index.php";
            
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.XPath("//body[@id='index']/div[@id='page']/div[@class='header-container']/header[@id='header']/div/div[@class='container']/div[@class='row']/div[@id='block_top_menu']/ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li[3]/a[1]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'More')]")).Click();
            driver.FindElement(By.XPath("//a[@class='btn btn-default button-plus product_quantity_up']//span")).Click();
            
            driver.FindElement(By.XPath("//select[@id='group_1']")).Click();
            
            driver.FindElement(By.XPath("//div[@id='uniform-group_1']")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'M')]")).Click();
            
            driver.FindElement(By.XPath("//a[@id='color_14']")).Click();
           
            driver.FindElement(By.XPath("//*[@id=\"add_to_cart\"]/button/span")).Click();
            


        }
        /*
        [Test]
        public void QuickView_and_add_to_cart()
        {

            By byProduct = By.CssSelector("li[class^='ajax_block_product']");
            By byQuickViewMobile = By.CssSelector("a[class^='quick-view-mobile']");
            By byQuickView = By.CssSelector("a[class^='quick-view']");
            By byFancyBoxFrame = By.CssSelector("iframe[id^='fancybox-frame']");

            homeURL = "http://automationpractice.com/index.php";

            driver.Navigate().GoToUrl(homeURL);

            var products = driver.FindElements(byProduct);

            IWebElement fadedShortTShirt = products[0];
            IWebElement quickView = fadedShortTShirt.FindElement(byQuickView);

            // Move mouse over image and click
            Actions action = new Actions(driver);
            action.MoveToElement(quickView)
                .Click()
                .Build()
                .Perform();
            Thread.Sleep(2000);  // Needs to be replaced with a suitable wait!!

            // Find the popup iframe
            IWebElement fancyBoxFrame = driver.FindElement(byFancyBoxFrame);
            // Switch driver commands to go to that iframe
            driver.SwitchTo().Frame(fancyBoxFrame);

            By byAddToCartButton = By.Name("Submit");
            IWebElement addToCartButton = driver.FindElement(byAddToCartButton);
            addToCartButton.Click();
            Thread.Sleep(5000);  // For debugging so it doesn't close too quickly - remove ASAP - code shouldn't really have any sleeps
        }*/

        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://SauceLabs.com";
            driver = new ChromeDriver();

        }


    }


}
