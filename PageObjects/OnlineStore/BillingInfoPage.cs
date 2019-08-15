using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.OnlineStore
{
    class BillingInfoPage
    {
        public By Address = By.XPath("//ul[@id='address_invoice']");
        public By oldAdress = By.Id("address1");
        public By oldCity = By.Id("city");
        public By oldPostCode = By.Id("postcode");
        public By oldCountry = By.Id("id_country");
        public By oldCompany = By.Id("company");
        public By saveAddress = By.Id("submitAddress");
        public By confirmUpdate = By.XPath("//h1[@class='page-heading']");
        
        Customer1 _customer = new Customer1();

        public void ClickOnUpdate(IWebDriver driver)
        {
            driver.FindElement(Address).Click(); 
        }

        public void ChangeAddress(IWebDriver driver)
        {
            driver.FindElement(oldAdress).Click();
            driver.FindElement(oldAdress).Clear();
            driver.FindElement(By.Id("address1")).SendKeys(_customer.getAddress());

        }

        public void ChangeCity(IWebDriver driver)
        {
            driver.FindElement(oldCity).Click();
            driver.FindElement(oldCity).Clear();
            driver.FindElement(By.Id("city")).SendKeys(_customer.getCity());
        }

        public void ChangeState(IWebDriver driver)
        {
            IWebElement dropdown1 = driver.FindElement(By.Id("id_state"));
            SelectElement select1 = new SelectElement(dropdown1);
            select1.SelectByText(_customer.getState());

        }

        public void ChangePostCode(IWebDriver driver)
        {
            driver.FindElement(oldPostCode).Click();
            driver.FindElement(oldPostCode).Clear();
            driver.FindElement(oldPostCode).SendKeys(_customer.getZip());
        }

        public void ChangeCountry(IWebDriver driver)
        {
            IWebElement dropdown2 = driver.FindElement(oldCountry);
            SelectElement select2 = new SelectElement(dropdown2);
            select2.SelectByText("United States");
        }

        public void ChangeCompany(IWebDriver driver)
        {
            driver.FindElement(oldCompany).Click();
            driver.FindElement(oldCompany).Clear();
            driver.FindElement(oldCompany).SendKeys(_customer.getCompany());
        }

        public void ClickSaveAddress(IWebDriver driver)
        {
            driver.FindElement(saveAddress).Click();
        }

        public string ConfirmUpdate(IWebDriver driver)
        {
            return driver.FindElement(confirmUpdate).Text;
        }

    }



}
