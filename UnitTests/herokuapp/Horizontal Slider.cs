using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using HerokuApp.ScreenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace HerokuApp
{
    [TestFixture]
    public class HorzontalSlider
    {


        private IWebDriver driver;
        HerokuAppHomePage herokuHome = new HerokuAppHomePage();
        private string TextNotFound;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }

        ////h1[contains(text(),'Not Found')]

        //header XPath //header[contains(text(),'A')] 

        [Test(Description = "Test the horizontal slider")]
        public void HorizontalSliderTest()
        {
            //ideal range to teach to the right
            string barRange = "5";

            FindHorizontalSliderPage();

            //click the slider.
            driver.FindElement(By.XPath("//div[@class='sliderContainer']//input")).Click();

            //Initial range value
            string CurrentValue = CheckingCurrentRange();

            while (CurrentValue != barRange)
            {
                //While we haven't reached the range value, keep pressing the right arrow button
                driver.FindElement(By.XPath("//div[@class='sliderContainer']//input")).SendKeys(Keys.ArrowRight);
                CurrentValue = CheckingCurrentRange();
            }
            //Checking if the range value is what we expect
            Assert.AreEqual(barRange, CheckingCurrentRange(), "Didn't make it to a range of " + barRange);

        }

        public void FindHorizontalSliderPage()
        {
            //Code that brings us to the Page
            herokuHome.GotoURL(driver);
            driver.FindElement(By.XPath("//a[contains(text(),'Horizontal Slider')]")).Click();


        }

        public string CheckingCurrentRange()
        {
            //What range are we on at this moment
            string rangeValue = driver.FindElement(By.Id("range")).Text;
            return rangeValue;

        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }
    }
}