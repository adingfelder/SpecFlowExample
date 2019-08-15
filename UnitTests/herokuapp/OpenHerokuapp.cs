using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;

namespace HerokuApp
{
    public class OpenHerokuapp
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ChromeDriver globaldriver;  //= new ChromeDriver();
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();



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
        public void AndyTestLoadPage()
        {
            log.Info("doing HerokuappTestLoadPage");
            herokuHome.GotoURL(globaldriver); // this loads the home url
 //           _homepage.ClickSignIn(globaldriver);
 //           Assert.AreEqual("planit training", _myAccountPage.getAccountName(globaldriver), "Account Name does not match");
            globaldriver.Close();
            log.Info("HerokuappTestLoadPage closed");

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

