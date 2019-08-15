using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumShoppingCart.ScreenModel;


namespace SeleniumShoppingCart.Step_Definitions
{
    
    [Binding]
    class ShoppingCartSteps
    {

        //private string baseURL = "http://www.automationpractice.com";
        private ChromeDriver chromeDriver;
        private HomePage _homepage;
        private MyAccountPage _myAccountPage;

        public ShoppingCartSteps()
        {
            chromeDriver = new ChromeDriver();
            _homepage = new HomePage();
            _myAccountPage = new MyAccountPage();
        }



        //private readonly Calculator calculator = new Calculator();

        [Given(@"I am on the store page")]
        public void GivenIAmOnTheStorePage()
        {
            
            _homepage.GotoURL(chromeDriver);
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("my store"));
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
           
            _homepage.ClickSignIn(chromeDriver);
            _homepage.EnterEmail(chromeDriver);
            _homepage.EnterPassword(chromeDriver);
            _homepage.ClickSignInButton(chromeDriver);
        }

        [Then(@"I should see my name")]
        public void ThenIShouldSeeMyName()
        {

            string actualValue = _myAccountPage.getAccountName(chromeDriver);
            Assert.AreEqual("planit training", actualValue, "Account Name does not match");
            chromeDriver.Quit();
            

        }

        [When(@"I click an item")]
        public void WhenIClickAnItem()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I should see item details")]
        public void ThenIShouldSeeItemDetails()
        {
            chromeDriver.Close();
            //ScenarioContext.Current.Pending();
        }

       

    }
}
