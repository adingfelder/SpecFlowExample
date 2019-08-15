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
    public class SearchForItemTest
    {
        private IWebDriver driver;
        public string homeURL;

        ChromeDriver globaldriver = new ChromeDriver();
        HomePage _homepage = new HomePage();

        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://automationpractice.com/index.php";
            driver = new ChromeDriver();

        }

        //Link Text Creation
        public By Item1result = By.LinkText("Blouse");
        public By Item2result = By.LinkText("Faded Short Sleeve T-shirts");


        [Test(Description = "Searches for multiple Items Test.")]
        public void CreateAccountTest()
        {   
            //searchbox ID and items are set
            string searchBoxID = "search_query_top";
            string Item1 = "Blouse";
            string Item2 = "Chiffon Dress";

            //Searching Item 1st Test
            SearchForItemIDTest(searchBoxID, Item1);
            driver.FindElement(Item1result).Click();


            //Searching Item 2nd Test 
            SearchForItemIDTest(searchBoxID, Item2);
            driver.FindElement(Item2result).Click();


        }

        public void SearchForItemIDTest(string searchBoxID, string searchedItem)
        {
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.Id(searchBoxID)).Click();
            driver.FindElement(By.Id(searchBoxID)).SendKeys(searchedItem);
        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }



    }


}