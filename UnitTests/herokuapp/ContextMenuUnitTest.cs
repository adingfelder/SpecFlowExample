using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using OpenQA.Selenium;
using UnitTestSpecFlow.PageObjects.HerokuApp;

namespace HerokuAppHome
{
    [TestFixture]
    public class ContextMenuUnitTest
    {
        ChromeDriver globaldriver;
        HerokuAppHomePage _herokuApp = new HerokuAppHomePage();
        ContextMenu _contextMenu = new ContextMenu();
        

        public ContextMenuUnitTest()
        {
            globaldriver = new ChromeDriver();
        }

        public void ContextMenuTest()
        {
            
            _herokuApp.GotoURL(globaldriver);
            _contextMenu.GoToContextMenu(globaldriver);
            _contextMenu.RightClickObBox(globaldriver);
            IAlert alert = globaldriver.SwitchTo().Alert();
            alert.Accept();
            globaldriver.Close();
            globaldriver.Quit();


        }


    }
}
