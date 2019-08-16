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
            // TODO:  add assertion that we are on the right page
            
            // first check the starting header values 
            // check the header in column 1
            Assert.AreEqual("A", CheckWhatsInColumn(1), "Wrong Header when starting");

            // header is ok.  now drag and drop
            // drag a onto b
            PerformDragFromCol_aToCol_b("a", "b");

            // now check if headers changed
            log.Info("checking result of drag and drop");
            Assert.AreEqual("A", CheckWhatsInColumn(2), "Wrong Header after dragging");
           
            //Assert.AreEqual("B", CheckWhatsInColumn(1), "Wrong Header");
            //PerformDragFromCol_aToCol_b("a", "b");
            //Assert.AreEqual("A", CheckWhatsInColumn(1), "Wrong Header");
            //Assert.AreEqual("B", CheckWhatsInColumn(2), "Wrong Header");
        }

        public void PerformDragFromCol_aToCol_b(string Col1, string Col2)
        {
            log.Info("doing drag and drop from "+Col1+" to "+ Col2);
            string elementIdOne = "column-" + Col1;
            string elementIdTwo = "column-" + Col2;
            //Drag from column 1 to column 2
            //IWebElement From = driver.FindElement(By.XPath("//div[@id='column-" + Col1 + "']"));
            //IWebElement To = driver.FindElement(By.XPath("//div[@id='column-" + Col2 + "']"));
            //Actions act = new Actions(driver);
            //act.DragAndDrop(From, To).Build().Perform();

            log.Info("finding element A");
            // TODO:  this should be in a page object model
            By OneBy = By.Id(elementIdOne);
            By TwoBy = By.Id(elementIdTwo);
            IWebElement elementOneFrom = driver.FindElement(OneBy);

            log.Debug("finding element B");
            IWebElement elementTwoTo = driver.FindElement(TwoBy);

            elementTwoTo.Click();
            //ask.Delay(1000).Wait();
            //elementOneFrom.Click();
            //Task.Delay(1000).Wait();

            Actions ac = new Actions(driver);
            
            // drag a onto b
            log.Debug("drag element A onto B");
            //ac.DragAndDrop(elementOneFrom, elementTwoTo).Build().Perform();

           // ac.DragAndDropToOffset(elementOneFrom, 100, 200).Build().Perform();
            // this should drop it
            Task.Delay(1000).Wait();

            Actions actions = ac.ClickAndHold(elementOneFrom);
            actions.MoveToElement(elementTwoTo);
            actions.Release();
            actions.Build();
            actions.Perform();



        }

        public void FindDragAndDropPage()
        {
            // load the website first
            herokuHome.GotoURL(driver);
            // TODO:  we should be defining this By element in a pageObject class
            driver.FindElement(By.XPath("//a[contains(text(),'Drag and Drop')]")).Click();
            log.Debug("found link for Drag and Drop and clicked it");
        }

        public string CheckWhatsInColumn(int ColNum)
        {
            log.Debug("checking what header is in column "+ ColNum);
            string TextColHeader = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[" + ColNum + "]/header[1]")).Text;
            log.Debug("found header: " + TextColHeader + " for column "+ ColNum);
            return TextColHeader;
        }
        /*
        public void dragdrop(IWebDriver driver, By ByFrom, By ByTo)
        {
            IWebElement LocatorFrom = driver.FindElement(ByFrom);
            IWebElement LocatorTo = driver.FindElement(ByTo);
            string xto = Convert.ToString(LocatorTo.Location.X);
            string yto = Convert.ToString(LocatorTo.Location.Y);
            ((IJavaScriptExecutor)driver).ExecuteScript("function simulate(f,c,d,e){var b,a=null;for(b in eventMatchers)if(eventMatchers[b].test(c)){a=b;break}if(!a)return!1;document.createEvent?(b=document.createEvent(a),a==\"HTMLEvents\"?b.initEvent(c,!0,!0):b.initMouseEvent(c,!0,!0,document.defaultView,0,d,e,d,e,!1,!1,!1,!1,0,null),f.dispatchEvent(b)):(a=document.createEventObject(),a.detail=0,a.screenX=d,a.screenY=e,a.clientX=d,a.clientY=e,a.ctrlKey=!1,a.altKey=!1,a.shiftKey=!1,a.metaKey=!1,a.button=1,f.fireEvent(\"on\"+c,a));return!0} var eventMatchers={HTMLEvents:/^(?:load|unload|abort|error|select|change|submit|reset|focus|blur|resize|scroll)$/,MouseEvents:/^(?:click|dblclick|mouse(?:down|up|over|move|out))$/}; " +
            "simulate(arguments[0],\"mousedown\",0,0); simulate(arguments[0],\"mousemove\",arguments[1],arguments[2]); simulate(arguments[0],\"mouseup\",arguments[1],arguments[2]); ",
            LocatorFrom, xto, yto);
        }

    */
        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }
    }
}