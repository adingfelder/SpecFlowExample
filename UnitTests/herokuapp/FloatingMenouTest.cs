using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;
using UnitTestSpecFlow.PageObjects.HerokuApp;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HerokuApp
{
    public class FloatingMenouTest
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ChromeDriver globaldriver;  //= new ChromeDriver();
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();
        FloatingMenu FloatingMen = new FloatingMenu();


        [SetUp]
        public void SetupTest()
        {
            // do some logging with our logger instead of console write
            // for more info see:  https://stackify.com/log4net-guide-dotnet-logging/
            log.Info("doing Herokuapp setup");
            // homeurl is set in herokuHome class
            globaldriver = new ChromeDriver();
        }

        [Test]
        public void FloatingMenu()
        {
            log.Info("doing HerokuappTestLoadPage");
            herokuHome.GotoURL(globaldriver);
            FloatingMen.ClickingFloatingMenu(globaldriver);
            FloatingMen.FloatingMenuMoves(globaldriver);
        }

        [TearDown]
        public void TearDownTest()
        {
            
            globaldriver.Quit();

        }

    }
}
