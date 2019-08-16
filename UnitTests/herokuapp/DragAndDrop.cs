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
using WindowsInput;
using UnitTestSpecFlow.PageObjects.HerokuApp;

namespace HerokuApp
{
    [TestFixture]
    public class DragAndDropTesting
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private IWebDriver driver;
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();
        // our page object model
        DragAndDrop dad = new DragAndDrop();


        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }

        [Test(Description = "TestDragAndDropFunctionality")]
        public void TestDragAndDrop()
        {
            // load the website first
            herokuHome.GotoURL(driver);

            log.Info("doing drag and drop - loading page");
            dad.FindDragAndDropPage(driver);
            // TODO:  add assertion that we are on the right page
            
            // first check the starting header values 
            // check the header in column 1
            Assert.AreEqual("A", dad.CheckWhatsInColumn(driver,1), "Wrong Header when starting");

            // header is ok.  now drag and drop
            // drag a onto b
            dad.PerformDragFromCol_aToCol_b(driver, "a", "b");

            // now check if headers changed
            log.Info("checking result of drag and drop");
            Assert.AreEqual("A", dad.CheckWhatsInColumn(driver,2), "Wrong Header after dragging");
           
            //Assert.AreEqual("B", CheckWhatsInColumn(1), "Wrong Header");
            //PerformDragFromCol_aToCol_b("a", "b");
            //Assert.AreEqual("A", CheckWhatsInColumn(1), "Wrong Header");
            //Assert.AreEqual("B", CheckWhatsInColumn(2), "Wrong Header");
        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }
    }
}