using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;
using System;
using System.Threading.Tasks;

namespace SeleniumShoppingCart
{

    [TestFixture]
    public class ContactUsTab
    {
        ChromeDriver driver;  //= new ChromeDriver();
        HomePage _homepage = new HomePage();
        //MyAccountPage _myAccountPage = new MyAccountPage();
        ContactPage contactPage = new ContactPage();

        [SetUp]
        public void SetupTest()
        {
            Console.WriteLine("doing SetupTest setup");
            // homeurl is set in HomePage class
            driver = new ChromeDriver();
        }

        [Test(Description = "Check SauceLabs Homepage for Login Link")]
        public void ContactTab()
        {
            Console.WriteLine("doing TestLogin");
            _homepage.GotoURL(driver);

            contactPage.ClickContactPage(driver);
            Task.Delay(1000).Wait();

            contactPage.ClickIdContact(driver);
            Task.Delay(1000).Wait();

            //driver.FindElement(customerButton).Click();
            contactPage.ClickCustomerButton(driver);

            contactPage.enterEmail(driver);

            // move this stuff  to the page object model
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

    }


}
