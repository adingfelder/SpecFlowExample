using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;
using UnitTestSpecFlow.PageObjects.HerokuApp;
using System.Threading.Tasks;

namespace HerokuApp
{
    public class FileDownload
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ChromeDriver globaldriver;  //= new ChromeDriver();
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();
        FileDownLoad filedownload = new FileDownLoad();


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
        public void fileupload()
        {
            log.Info("doing HerokuappTestLoadPage");
            herokuHome.GotoURL(globaldriver);
            filedownload.ClickFileDownload(globaldriver);
            filedownload.ClickSimpleTxt(globaldriver);
            filedownload.ClickSomeTxtFile(globaldriver);
            filedownload.ClickScreenShot(globaldriver);

        }


        [TearDown]
        public void TearDownTest()
        {
            
            globaldriver.Quit();

        }

    }
}
