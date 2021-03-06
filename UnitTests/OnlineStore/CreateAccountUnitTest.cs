﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;

namespace SeleniumShoppingCart
{


    [TestFixture]
    public class CreateAccount
    { 
        private IWebDriver driver;
        public string homeURL;

        //ChromeDriver globaldriver = new ChromeDriver();
        HomePage _homepage = new HomePage();
        MyAccountPage _myAccountPage = new MyAccountPage();

        [Test(Description = "Creates an account automatically.")]
        public void CreateAccountTest()
        {

            Customer1 customerA = new Customer1();
            homeURL = "http://automationpractice.com/index.php";
            driver.Navigate().GoToUrl(homeURL);
            driver.FindElement(By.XPath("//a[@class='login']")).Click();
            driver.FindElement(By.XPath("//input[@id='email_create']")).Click();
            driver.FindElement(By.XPath("//input[@id='email_create']")).SendKeys(customerA.getEmail());
            driver.FindElement(By.XPath("//form[@id='create-account_form']//span[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath("//div[@class='clearfix']//div[1]//label[1]")).Click();

            //firstname_customer
            driver.FindElement(By.Id("customer_firstname")).Click();
            driver.FindElement(By.Id("customer_firstname")).Clear();
            driver.FindElement(By.Id("customer_firstname")).SendKeys(customerA.getFirstName());
            //Lastname_customer
            driver.FindElement(By.Id("customer_lastname")).Click();
            driver.FindElement(By.Id("customer_lastname")).Clear();
            driver.FindElement(By.Id("customer_lastname")).SendKeys(customerA.getLastName());

            //password_customer
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys(customerA.getCompany());

            //DOB
            IWebElement dropdownday = driver.FindElement(By.Id("days"));
            SelectElement selectday = new SelectElement(dropdownday);
            selectday.SelectByIndex(1);

            //selectday.SelectByText(customerA.getDOB_day());
            IWebElement dropdownmonth = driver.FindElement(By.Id("months"));
            SelectElement selectmonth = new SelectElement(dropdownmonth);
            selectmonth.SelectByIndex(3);

            //selectmonth.SelectByText(customerA.getDOB_month());
            IWebElement dropdownyear = driver.FindElement(By.Id("years"));
            SelectElement selectyear = new SelectElement(dropdownyear);

            //selectyear.SelectByText(customerA.getDOB_year());
            selectyear.SelectByIndex(1);

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
            driver.FindElement(By.Id("alias")).SendKeys(customerA.getAssign());

            //Register
            driver.FindElement(By.Name("submitAccount")).Click();
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
            Console.WriteLine("This line is working ------------");
            Console.WriteLine("The name is " + customerA.getFirstName() + " " + customerA.getLastName());
            //Console.WriteLine("The global driver is " + _myAccountPage.getRegisterName(globaldriver));
            Assert.AreEqual((customerA.getFirstName() + " " + customerA.getLastName()), _myAccountPage.getAccountName(driver), "Account Name does not match");
            driver.Quit();
            


        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }


        [SetUp]
        public void SetupTest()
        {
            //homeURL = "http://SauceLabs.com";
            driver = new ChromeDriver();

        }


    }


}