using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;

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
