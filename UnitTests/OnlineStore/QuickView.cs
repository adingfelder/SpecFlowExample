using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SeleniunUsingCSharpAndNunit
{
    [TestFixture]
    public class SearchTShirts2
    {
        private IWebDriver driver;
        public string homeURL;


        [Test]
        public void Login_is_on_home_page()
        {


            homeURL = "http://automationpractice.com/index.php";

            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[3]/div/div[1]/div/div[1]/a/i")).Click();

            Task.Delay(1000).Wait();

            driver.FindElement(By.XPath("//button[@name='Submit']")).Click();



        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://SauceLabs.com";
            driver = new ChromeDriver();

        }


    }


}
