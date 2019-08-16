using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
namespace HerokuApp
{
    [TestFixture]
    public class HoverTesting
    {


        private IWebDriver driver;
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();
        private string TextNotFound;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }

        ////h1[contains(text(),'Not Found')]

        //header XPath //header[contains(text(),'A')] 

        [Test(Description = "TestDragAndDropFunctionality")]
        public void Hover()
        {
            FindHoverPage();
            HoverClickOnViewProfile(1);
            DidWeNavigateToTheNotFoundPage();

            FindHoverPage();
            HoverClickOnViewProfile(2);
            DidWeNavigateToTheNotFoundPage();

            FindHoverPage();
            HoverClickOnViewProfile(3);
            DidWeNavigateToTheNotFoundPage();

   


        }

        public void HoverClickOnViewProfile(int Number)
        {
            //Code that takes one to the Not Found Page for a selected User number
            //Only works when Images are the same.
            driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[" + Number + "]/img[1]")).Click();
            driver.FindElement(By.XPath("//div[@class='example']//div[" + Number + "]//div[1]//a[1]")).Click();
        }

        public void DidWeNavigateToTheNotFoundPage()
        {         
            //Checking for if the code made it to the Not Found Page by clicking on the user
            string TextNotFound = driver.FindElement(By.XPath("//h1[contains(text(),'Not Found')]")).Text;
            Assert.AreEqual("Not Found", TextNotFound, "Didn't make it to Not Found Page");
        }



        public void FindHoverPage()
        {
            //Code that brings us to the Page
            herokuHome.GotoURL(driver);
            driver.FindElement(By.XPath("//a[contains(text(),'Hovers')]")).Click();
        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }
    }
}