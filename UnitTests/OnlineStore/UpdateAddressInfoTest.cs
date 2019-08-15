//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;

namespace SeleniumShoppingCart
{


    [TestFixture]
    public class UpdateAddressInfoTest
    {
        private IWebDriver driver;
        public string homeURL;


        [Test(Description = "Update Address")]
        public void UpdateBillingInfo()
        {

            Customer1 customerA = new Customer1();
            homeURL = "http://automationpractice.com/index.php";
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("WaltDisney@Disney.com");
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys("123456");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'My addresses')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Add a new address')]")).Click();
            //Firstname
            driver.FindElement(By.Id("firstname")).Click();
            driver.FindElement(By.Id("firstname")).Clear();
            driver.FindElement(By.Id("firstname")).SendKeys(customerA.getFirstName());
            //Lastname
            driver.FindElement(By.Id("lastname")).Click();
            driver.FindElement(By.Id("lastname")).Clear();
            driver.FindElement(By.Id("lastname")).SendKeys(customerA.getLastName());
            //Company
            driver.FindElement(By.Id("company")).Click();
            driver.FindElement(By.Id("company")).Clear();
            driver.FindElement(By.Id("company")).SendKeys(customerA.getCompany());
            //Address
            driver.FindElement(By.Id("address1")).Click();
            driver.FindElement(By.Id("address1")).Clear();
            driver.FindElement(By.Id("address1")).SendKeys(customerA.getAddress());
            //City
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys(customerA.getCity());
            //State
            IWebElement dropdown1 = driver.FindElement(By.Id("id_state"));
            SelectElement select1 = new SelectElement(dropdown1);
            select1.SelectByText(customerA.getState());
            //PostalCode
            driver.FindElement(By.Id("postcode")).Click();
            driver.FindElement(By.Id("postcode")).Clear();
            driver.FindElement(By.Id("postcode")).SendKeys(customerA.getZip());
            //Country
            IWebElement dropdown2 = driver.FindElement(By.Id("id_country"));
            SelectElement select2 = new SelectElement(dropdown2);
            select2.SelectByText("United States");

            //Mobilephone
            driver.FindElement(By.Id("phone_mobile")).Click();
            driver.FindElement(By.Id("phone_mobile")).Clear();
            driver.FindElement(By.Id("phone_mobile")).SendKeys(customerA.getMobile());
            //AdressAssignment
            driver.FindElement(By.Id("alias")).Click();
            driver.FindElement(By.Id("alias")).Clear();
            driver.FindElement(By.Id("alias")).SendKeys(customerA.getAssign());

            //saving
            driver.FindElement(By.XPath("//span[contains(text(),'Save')]")).Click();

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
