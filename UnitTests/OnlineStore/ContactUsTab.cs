using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;
using System.Threading.Tasks;

namespace SeleniumShoppingCart
{


    [TestFixture]
    public class ContactUsTab
    {
        private IWebDriver driver;
        public string homeURL;


        [Test(Description = "Check SauceLabs Homepage for Login Link")]
        public void ContactTab()
        {

            Customer1 customerA = new Customer1();
            homeURL = "http://automationpractice.com/index.php";
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.Id("contact-link")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.Id("id_contact")).Click();
            Task.Delay(1000).Wait();
            driver.FindElement(By.XPath("//option[contains(text(),'Customer service')]")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("WaltDisney@Disney.com");
            driver.FindElement(By.Id("id_order")).Click();
            driver.FindElement(By.Id("id_order")).Clear();
            driver.FindElement(By.Id("id_order")).SendKeys("126548");
            driver.FindElement(By.Id("message")).Click();
            driver.FindElement(By.Id("message")).Clear();
            driver.FindElement(By.Id("message")).SendKeys("Your customer service sucks");
            driver.FindElement(By.XPath("//span[contains(text(),'Send')]")).Click();
            Task.Delay(1000).Wait();

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
