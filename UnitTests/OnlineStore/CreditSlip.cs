﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumShoppingCart
{


    [TestFixture]
    public class CreditSlip
    {
        private IWebDriver driver;
        public string homeURL;
        ScreenModel.MyAccountPage _myAccountPage;


        [SetUp]
        public void SetupTest()
        {
            //homeURL = "http://SauceLabs.com";
            driver = new ChromeDriver();
            _myAccountPage = new ScreenModel.MyAccountPage();


        }


        [Test(Description = "Check SauceLabs Homepage for Login Link")]
        public void MyCreditSlipButton()
        {


            homeURL = "http://automationpractice.com/index.php";
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("WaltDisney@Disney.com");
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys("123456");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'My credit slips')]"));

            //driver.FindElement(By.XPath("//h1[@class='page-heading bottom-indent']")).text;

            //Assert.AreEqual("planit training", _myAccountPage.getAccountName(driver), "Account Name does not match");

        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }




    }


}