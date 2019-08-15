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


        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }



        //header XPath //header[contains(text(),'A')] 

        [Test(Description = "TestDragAndDropFunctionality")]
        public void Hover()
        {
            FindDragAndDropPage();
        }




        public void FindDragAndDropPage()
        {
            herokuHome.GotoURL(driver);
            driver.FindElement(By.XPath("//a[contains(text(),'Drag and Drop')]")).Click();
        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }
    }
}