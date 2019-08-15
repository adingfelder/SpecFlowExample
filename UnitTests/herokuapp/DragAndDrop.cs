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
    public class DragAndDropTesting
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private IWebDriver driver;
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();


        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }



        //header XPath //header[contains(text(),'A')] 

        [Test(Description = "TestDragAndDropFunctionality")]
        public void DragAndDrop()
        {
            log.Info("doing drag and drop - loading page");
            FindDragAndDropPage();
            
            // first check the header in column 1
            Assert.AreEqual("A", CheckWhatsInColumn(1), "Wrong Header");

            // drag a onto b
            PerformDragFromCol_aToCol_b("a", "b");

            // now check if headers changed
            log.Info("checking result of drag and drop");
            Assert.AreEqual("A", CheckWhatsInColumn(2), "Wrong Header");
           
            //Assert.AreEqual("B", CheckWhatsInColumn(1), "Wrong Header");
            //PerformDragFromCol_aToCol_b("a", "b");
            //Assert.AreEqual("A", CheckWhatsInColumn(1), "Wrong Header");
            //Assert.AreEqual("B", CheckWhatsInColumn(2), "Wrong Header");
        }

        public void PerformDragFromCol_aToCol_b(string Col1, string Col2)
        {
            log.Info("doing drag and drop from "+Col1+" to "+ Col2);
            string one = "column-" + Col1;
            string two = "column-" + Col2;
            //Drag from column 1 to column 2
            //IWebElement From = driver.FindElement(By.XPath("//div[@id='column-" + Col1 + "']"));
            //IWebElement To = driver.FindElement(By.XPath("//div[@id='column-" + Col2 + "']"));
            //Actions act = new Actions(driver);
            //act.DragAndDrop(From, To).Build().Perform();

            log.Info("finding element A");
            // TODO:  this should be in a page object model
            IWebElement From = driver.FindElement(By.Id(one));

            log.Debug("finding element B");
            IWebElement To = driver.FindElement(By.Id(two));

            Actions ac = new Actions(driver);
            // drag a onto b
            log.Debug("drag element A onto B");
            ac.DragAndDrop(From, To);
            ac.Build().Perform();
            // this should drop it

            log.Info("yay we made it");

        }



        public void FindDragAndDropPage()
        {
            herokuHome.GotoURL(driver);
            // TODO:  we should be defining this By element in a pageObject class
            driver.FindElement(By.XPath("//a[contains(text(),'Drag and Drop')]")).Click();
            log.Debug("found link for Drag and Drop and clicked it");
        }

        public string CheckWhatsInColumn(int ColNum)
        {
            log.Debug("checking what header is in column "+ ColNum);
            string TextColHeader = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[" + ColNum + "]/header[1]")).Text;
            log.Debug("found: " + TextColHeader);
            return TextColHeader;
        }



        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }
    }
}