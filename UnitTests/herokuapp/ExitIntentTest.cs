using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;
using OpenQA.Selenium;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace HerokuApp
{
    public class ExitIntentTest
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ChromeDriver globaldriver;  //= new ChromeDriver();
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();

        private By exitIntent = By.LinkText("Exit Intent");

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
        public void HerokuAppExitIntent()
        {
            log.Info("doing HerokuappTestExitIntent");
            herokuHome.GotoURL(globaldriver); // this loads the home url
 //           _homepage.ClickSignIn(globaldriver);
 //           Assert.AreEqual("planit training", _myAccountPage.getAccountName(globaldriver), "Account Name does not match");
            globaldriver.FindElement(exitIntent).Click();
            //Task.Delay(1000).Wait(); //verify above statement

            /*
            Actions action = new Actions(globaldriver);
            action.MoveByOffset(600, -1).Build().Perform();
            Task.Delay(1000).Wait(); //verify above statement
            */




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

