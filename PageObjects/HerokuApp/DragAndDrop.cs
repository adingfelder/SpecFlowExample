using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    /// <summary>
    /// Summary description for DropDownBox
    /// </summary>
    [TestClass]
    public class DragAndDrop
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        By dropLink = By.XPath("//a[contains(text(),'Drag and Drop')]");

        public void FindDragAndDropPage(IWebDriver driver)
        {
            // TODO:  we should be defining this By element in a pageObject class
            driver.FindElement(dropLink).Click();
            log.Debug("found link for Drag and Drop and clicked it");
        }

        public string CheckWhatsInColumn(IWebDriver driver, int ColNum)
        {
            By colHeader = By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[" + ColNum + "]/header[1]");

            log.Debug("checking what header is in column " + ColNum);
            string TextColHeader = driver.FindElement(colHeader).Text;
            log.Debug("found header: " + TextColHeader + " for column " + ColNum);
            return TextColHeader;
        }

        public void PerformDragFromCol_aToCol_b(IWebDriver driver, string Col1, string Col2)
        {
            log.Info("doing drag and drop from " + Col1 + " to " + Col2);
            string elementIdOne = "column-" + Col1;
            string elementIdTwo = "column-" + Col2;
            By OneBy = By.Id(elementIdOne);
            By TwoBy = By.Id(elementIdTwo);

            //Drag from column 1 to column 2
            //IWebElement From = driver.FindElement(By.XPath("//div[@id='column-" + Col1 + "']"));
            //IWebElement To = driver.FindElement(By.XPath("//div[@id='column-" + Col2 + "']"));


            IWebElement elementOneFrom = driver.FindElement(OneBy);
            IWebElement elementTwoTo = driver.FindElement(TwoBy);

            Actions ac = new Actions(driver);

            // drag a onto b
            log.Debug("drag element A onto B");
            //ac.DragAndDrop(elementOneFrom, elementTwoTo).Build().Perform();

            // ac.DragAndDropToOffset(elementOneFrom, 100, 200).Build().Perform();
            // this should drop it
            Task.Delay(1000).Wait();

            //Actions act = new Actions(driver);
            //act.DragAndDrop(From, To).Build().Perform();

            /*      Actions actions = ac.ClickAndHold(elementOneFrom);
                    actions.MoveToElement(elementTwoTo);
                    actions.Release();
                    actions.Build();
                    actions.Perform();
        */

            // cant get actions or draganddrop to work so using simulator which also isnt working
            var sim = new WindowsInput.InputSimulator(); //using nugget package by michael noonan

            int x1 = elementOneFrom.Location.X;
            int y1 = elementOneFrom.Location.Y;
            int x2 = elementTwoTo.Location.X;
            int y2 = elementTwoTo.Location.Y;

            sim.Mouse.MoveMouseTo(x1, y1); // move mouse above the viewport pane
            Task.Delay(1000).Wait();
            sim.Mouse.LeftButtonDown();
            sim.Mouse.MoveMouseTo(x2, y2); // move mouse above the viewport pane
            Task.Delay(1000).Wait();
            sim.Mouse.LeftButtonUp();
            Task.Delay(1000).Wait();
        }

    }
}
