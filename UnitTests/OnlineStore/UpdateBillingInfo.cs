using System;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using SeleniumShoppingCart.ScreenModel;
using UnitTestSpecFlow.PageObjects.OnlineStore;
using NUnit.Framework;

namespace UnitTestSpecFlow.UnitTests.OnlineStore
{
   
    [TestFixture]
    public class UpdateBillingInfo
    {
        ChromeDriver globaldriver;
        HomePage _homePage = new HomePage();
        ViewDetailPage _detailPage = new ViewDetailPage();
        TShirtsDetails _tShirtPage = new TShirtsDetails();
        BillingInfoPage _billingAddress = new BillingInfoPage();


        public UpdateBillingInfo()
        {
            globaldriver = new ChromeDriver();

           
        }

        public void UpdateBillingTest()
        {
            _homePage.GotoURL(globaldriver);
            _homePage.ClickSignIn(globaldriver);
            _homePage.EnterEmail(globaldriver);
            _homePage.EnterPassword(globaldriver);
            _homePage.ClickSignInButton(globaldriver);
            _homePage.GotoURL(globaldriver);
            _detailPage.ClickMore(globaldriver);
            _tShirtPage.AddToCart(globaldriver);
            _tShirtPage.ProceedToCheckOut(globaldriver);
            _tShirtPage.FinalCheckOut(globaldriver);
            _billingAddress.ClickOnUpdate(globaldriver);
            _billingAddress.ChangeAddress(globaldriver);
            _billingAddress.ChangeCity(globaldriver);
            _billingAddress.ChangeState(globaldriver);
            _billingAddress.ChangePostCode(globaldriver);
            _billingAddress.ChangeCountry(globaldriver);
            _billingAddress.ChangeCompany(globaldriver);
            _billingAddress.ClickSaveAddress(globaldriver);
            Assert.AreEqual("Address", _billingAddress.ConfirmUpdate(globaldriver), "Something went wrong" );
            globaldriver.Close();
            


        }

        [TearDown]
        public void TearDownTest()
        {
            globaldriver.Quit();
        }



    }
}
