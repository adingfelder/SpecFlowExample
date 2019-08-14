//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SimpleSeleniumExample
{


    [TestFixture]
    public class Chrome_Sample_test_DANIBOI
    {
        private IWebDriver driver;
        public string homeURL ;


        [SetUp]
        public void SetupTest()
        {
            homeURL =  "http://automationpractice.com/index.php";
            driver = new ChromeDriver();

        }


        [Test(Description = "Check online store Homepage for Login Link")]
        public void DanniLoginIsOnHomePage()
        {
           
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("WaltDisney@Disney.com");
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys("123456");
            driver.FindElement(By.Id("SubmitLogin")).Click();


        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }




    }


}