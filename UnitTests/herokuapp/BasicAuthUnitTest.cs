using System;
using System.Text;
using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using UnitTestSpecFlow.PageObjects.HerokuApp;
using HerokuApp.ScreenModel;
using OpenQA.Selenium;
using System.Windows.Forms;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace HerokuApp
{
    
    [TestFixture]
    public class BasicAuthUnitTest
    {
        ChromeDriver globaldriver;
        HerokuAppHomePage _herokuApp = new HerokuAppHomePage();
        BasicAuth _basicAuth = new BasicAuth();
        
        

        [SetUp]
        public void SetUp()
        {
            globaldriver = new ChromeDriver();
        }

        private string url = "http://admin:admin@the-internet.herokuapp.com/basic_auth";
        [Test]
        public void BasicAuthTest()
        {
            

            globaldriver.Navigate().GoToUrl(url);
            Task.Delay(2000).Wait();
            Assert.AreEqual("Congratulations! You must have the proper credentials.", globaldriver.FindElement(By.CssSelector("#content > div > p")).Text, "Something went wrong");
           
            globaldriver.Close();
            
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
