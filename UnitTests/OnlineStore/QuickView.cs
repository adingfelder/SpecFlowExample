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
    public class SearchTShirts2
    {
        private IWebDriver driver;
        public string homeURL;


        [Test]
        public void Login_is_on_home_page()
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



        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://SauceLabs.com";
            driver = new ChromeDriver();

        }


    }


}
