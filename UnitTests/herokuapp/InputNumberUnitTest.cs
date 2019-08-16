using System;
using HerokuApp.ScreenModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestSpecFlow.PageObjects.HerokuApp;

namespace HerokuApp
{
    [TestFixture]
    public class InputNumberUnitTest
    {
        ChromeDriver globaldriver;
        HerokuAppHomePage _herokuApp = new HerokuAppHomePage();
        InputNumber _inputNumber = new InputNumber();

        [SetUp]
        public void SetUp()
        {
            globaldriver = new ChromeDriver();
        }

        [Test]
        public void InputNumberTest()
        {
            _herokuApp.GotoURL(globaldriver);
            _inputNumber.GoToPage(globaldriver);
            _inputNumber.Select(globaldriver);
            string target = globaldriver.FindElement(By.ClassName("example")).Text;
            Assert.AreEqual("-1", target, "something wrong");
            
            globaldriver.Close();

        }

        [TearDown]
        public void TeaarDownTest()
        {
            globaldriver.Quit();
        }
    }
}
