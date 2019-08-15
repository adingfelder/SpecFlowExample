using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;

namespace SeleniumShoppingCart
{


    [TestFixture]
    public class RemoveFromCartTest
    {
        private IWebDriver driver;
        public string homeURL;

        HomePage _homepage = new HomePage();
        ViewDetailPage _detailPage = new ViewDetailPage();

        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://automationpractice.com/index.php";
            driver = new ChromeDriver();

        }
        //Calling Search For Item code to test

        InCartChecker _InCartCheck = new InCartChecker();

        [Test(Description = "RemovesItemFromCart")]
        public void RemovesItemsFromCart()
        {
            //searchbox ID and items are set
            //searchbox Item parameters set
            string searchBoxID = "search_query_top";
            //Item parameters**********************************************************
            //whats searched
            string Item1 = "Blouse";
            //whats found
            string Item1result = "Blouse";
            string blouseDesc = "Short sleeved blouse with feminine draped sleeve detail.";
            string id_blouseDesc = "Short sleeved blouse with feminine draped sleeve d";
            //*********************************************************************************************************
            //Searching to Item
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.Id(searchBoxID)).Click();
            driver.FindElement(By.Id(searchBoxID)).SendKeys(Item1);
            By foundItem = By.LinkText(Item1result);
            driver.FindElement(foundItem).Click();
            Assert.AreEqual(blouseDesc, _detailPage.GetItemDetail(driver, id_blouseDesc), "Wrong item");
            //**********************************************************************************************************
            //Adding to Cart
            driver.FindElement(By.XPath(XPathbyText("Add to cart"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath(XPathbyText("Proceed to checkout"))).Click();
            //Checking Item is in Cart
            Assert.AreEqual(Item1, _InCartCheck.InCartCheck(driver,Item1), "Item not in Cart");
            //**********************************************************************************************************
            //Deleting from Cart
            driver.FindElement(By.XPath("//i[@class='icon-trash']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //Checking Item has been removed
            driver.FindElement(By.XPath("//p[@class='alert alert-warning']"));
            

        }

        public string XPathbyText(string boxText)
        {
            string XPathText = "//span[contains(text(),'" + boxText +"')]";
            return XPathText;
        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }

    }





}