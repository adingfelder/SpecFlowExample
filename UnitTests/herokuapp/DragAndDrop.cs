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
            FindDragAndDropPage();
            Assert.AreEqual("A", CheckWhatsInColumn(1), "Wrong Header");
            PerformDragFromCol_aToCol_b("a", "b");
            Assert.AreEqual("A", CheckWhatsInColumn(2), "Wrong Header");
            //Assert.AreEqual("B", CheckWhatsInColumn(1), "Wrong Header");
            //PerformDragFromCol_aToCol_b("a", "b");
            //Assert.AreEqual("A", CheckWhatsInColumn(1), "Wrong Header");
            //Assert.AreEqual("B", CheckWhatsInColumn(2), "Wrong Header");
        }

        public void PerformDragFromCol_aToCol_b(string Col1, string Col2)
        {
            //Drag from column 1 to column 2
            //IWebElement From = driver.FindElement(By.XPath("//div[@id='column-" + Col1 + "']"));
            //IWebElement To = driver.FindElement(By.XPath("//div[@id='column-" + Col2 + "']"));
            //Actions act = new Actions(driver);
            //act.DragAndDrop(From, To).Build().Perform();

           
           

            IWebElement From = driver.FindElement(By.Id("column-a"));
            IWebElement To = driver.FindElement(By.Id("column-b"));
            Actions ac = new Actions(driver);
            ac.DragAndDrop(From, To);
            ac.Build().Perform();
            Console.WriteLine("yay we made it");


        }



        public void FindDragAndDropPage()
        {
            herokuHome.GotoURL(driver);
            driver.FindElement(By.XPath("//a[contains(text(),'Drag and Drop')]")).Click();
        }

        public string CheckWhatsInColumn(int ColNum)
        {
            string TextColHeader = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[" + ColNum + "]/header[1]")).Text;
            return TextColHeader;
        }



        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }
    }
}