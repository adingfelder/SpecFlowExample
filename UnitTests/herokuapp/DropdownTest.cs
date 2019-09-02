using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;
using UnitTestSpecFlow.PageObjects.HerokuApp;

namespace HerokuApp
{
    public class DropdownTest
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ChromeDriver globaldriver;  //= new ChromeDriver();
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();
        DropDownBox drop = new DropDownBox();


        [SetUp]
        public void SetupTest()
        {
            // do some logging with our logger instead of console write
            // for more info see:  https://stackify.com/log4net-guide-dotnet-logging/
            log.Info("doing Herokuapp setup");
            // homeurl is set in herokuHome class
            globaldriver = new ChromeDriver();
            // new comment
        }

        [Test]
        public void AndyTestLoadPage()
        {
            log.Info("doing HerokuappTestLoadPage");
            herokuHome.GotoURL(globaldriver);
            drop.ClickDropDown(globaldriver);
            drop.SelectingDropdown(globaldriver);
            drop.SelectOptionTwo(globaldriver);

        }


        [TearDown]
        public void TearDownTest()
        {
            Console.WriteLine("doing HerokuappTestLoadPage teardown - quit");
            globaldriver.Quit();
            //agnes doesnt like not having a tick
        }

    }
}


