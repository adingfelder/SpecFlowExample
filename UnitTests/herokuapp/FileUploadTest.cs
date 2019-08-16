using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;
using UnitTestSpecFlow.PageObjects.HerokuApp;
using System.Threading.Tasks;

namespace HerokuApp
{
    public class UploadFiletest
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ChromeDriver globaldriver;  //= new ChromeDriver();
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();
        FileUpload file = new FileUpload();


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
            file.ClickingFileUpload(globaldriver);

            log.Debug("choosing file");
            bool success = file.ChoosingFile(globaldriver);
            Assert.IsTrue(success, "Error Selecting File");

            log.Debug("done choosing file");
            Task.Delay(1000).Wait();
            file.UploadFile(globaldriver);
          
        }


        [TearDown]
        public void TearDownTest()
        {
            
            globaldriver.Quit();

        }

    }
}
