using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using UnitTestSpecFlow.PageObjects.HerokuApp;
using HerokuApp.ScreenModel;
using OpenQA.Selenium;

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

        [Test]
        public void BasicAuthTest()
        {
            _herokuApp.GotoURL(globaldriver);
            _basicAuth.GoToBasicAuth(globaldriver);
            Console.WriteLine("Click the Basic Auth Link");
            _basicAuth.EnterAuth(globaldriver);
            Console.WriteLine("You have entered the auth");
            globaldriver.Close();
            globaldriver.Quit();
        }
        
    }
}
