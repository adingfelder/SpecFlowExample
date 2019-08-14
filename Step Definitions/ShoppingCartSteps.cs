using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniunShoppingCart.ScreenModel;


namespace SeleniunShoppingCart.Step_Definitions
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
            //chromeDriver.Navigate().GoToUrl(baseURL);  
            _homepage.GotoURL(chromeDriver);
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("my store"));
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
           // _homepage.GotoURL(chromeDriver);
            _homepage.ClickSignIn(chromeDriver);
            _homepage.EnterEmail(chromeDriver);
            _homepage.EnterPassword(chromeDriver);
            _homepage.ClickSignInButton(chromeDriver);
        }

        [Then(@"I should see my name")]
        public void ThenIShouldSeeMyName()
        {

//            _homepage.GotoURL(chromeDriver);
//            _homepage.ClickSignIn(chromeDriver);
//            _homepage.EnterEmail(chromeDriver);
//            _homepage.EnterPassword(chromeDriver);
//            _homepage.ClickSignInButton(chromeDriver);
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
            //ScenarioContext.Current.Pending();
        }

        /*
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculator.total);
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            calculator.Divide();
        }
        */

    }
}
