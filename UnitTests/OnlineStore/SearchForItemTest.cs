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

        HomePage _homepage = new HomePage();
        ViewDetailPage _detailPage = new ViewDetailPage();

        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://automationpractice.com/index.php";
            driver = new ChromeDriver();

        }



        [Test(Description = "Searches for multiple Items Test.")]
        public void SearchforItemTest()
        {
            //searchbox ID and items are set
            //searchbox Item parameters set
            string searchBoxID = "search_query_top";
            //first Item parameters**********************************************************
            //whats searched
            string Item1 = "Blouse";
            //whats found
            string Item1result = "Blouse";
            string blouseDesc = "Short sleeved blouse with feminine draped sleeve detail.";
            ////div[@class='rte align_justify']//p[contains(text(),'Short sleeved blouse with feminine draped sleeve d')]
            string id_blouseDesc = "Short sleeved blouse with feminine draped sleeve d";
            //second Item parameters ********************************************************
            //whats searched
            string Item2 = "Chiffon Dress";
            //whats found
            string Item2result = "Printed Chiffon Dress";
            string chiffonDressDesc = "Printed chiffon knee length dress with tank straps. Deep v-neckline.";
            string id_chiffonDressDesc = "Printed chiffon knee length dress with tank straps";

            //Calling the test method SearchForItemIDTest with the parameters set
            //Searching Item 1st Test
            SearchForItemIDTest(searchBoxID, Item1, Item1result, blouseDesc, id_blouseDesc);

            //Searching Item 2nd Test 
            SearchForItemIDTest(searchBoxID, Item2, Item2result, chiffonDressDesc, id_chiffonDressDesc);

        }

        public void SearchForItemIDTest(string searchBoxID, string searchedItem, string itemExpectedResult, string itemDesc, string id_itemDesc)
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.FindElement(By.Id(searchBoxID)).Click();
            driver.FindElement(By.Id(searchBoxID)).SendKeys(searchedItem);
            By foundItem = By.LinkText(itemExpectedResult);
            driver.FindElement(foundItem).Click();
            Assert.AreEqual(itemDesc, _detailPage.GetItemDetail(driver, id_itemDesc), "Wrong item");
        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }

    }





}