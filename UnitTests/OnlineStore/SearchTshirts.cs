using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SeleniunShoppingCart
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
            Task.Delay(1000).Wait();
            driver.FindElement(By.XPath("//select[@id='group_1']")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.XPath("//div[@id='uniform-group_1']")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'M')]")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.XPath("//a[@id='color_14']")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.XPath("//*[@id=\"add_to_cart\"]/button/span")).Click();
            Task.Delay(5000).Wait();


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
