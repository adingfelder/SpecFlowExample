using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using OpenQA.Selenium;
using UnitTestSpecFlow.PageObjects.HerokuApp;
using System;

namespace HerokuApp
{
    [TestFixture]
    public class ContextMenuUnitTest
    {
        ChromeDriver globaldriver;
        HerokuAppHomePage _herokuApp = new HerokuAppHomePage();
        ContextMenu _contextMenu = new ContextMenu();
        
        
        
        [SetUp]
        public void SetUp()
        {
            globaldriver = new ChromeDriver();
        }

        [Test]
        public void ContextMenuTest()
        {
            
            _herokuApp.GotoURL(globaldriver);
            _contextMenu.GoToContextMenu(globaldriver);
            _contextMenu.RightClickObBox(globaldriver);
            System.Threading.Thread.Sleep(5000);
            IAlert alert = globaldriver.SwitchTo().Alert();
            alert.Accept();
            _contextMenu.ClickBlankSpace(globaldriver);
            Assert.AreEqual("Context Menu", _contextMenu.ContextMenuText(globaldriver), "Something went wrong");
            globaldriver.Close();
            globaldriver.Quit();


        }


    }
}
