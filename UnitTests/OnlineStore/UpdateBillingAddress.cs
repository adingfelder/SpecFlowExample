using OpenQA.Selenium.Chrome;
using SeleniumShoppingCart.ScreenModel;
using NUnit.Framework;
using SeleniumShoppingCart;

namespace UnitTestSpecFlow.UnitTests.OnlineStore
{
   
    public class UpdateBillingAddress
    {
        
        ChromeDriver globaldriver;
        HomePage _homepage = new HomePage();
        ViewDetailPage _detailpage = new ViewDetailPage();
        SearchTShirts _searchTshits = new SearchTShirts();
        

        [SetUp]
        public void SetUptest()
        {
            globaldriver = new ChromeDriver();
        }

        [Test]
        public void UpdateBillingInfo()
        {
            _homepage.GotoURL(globaldriver);
            _homepage.ClickSignIn(globaldriver);
            _homepage.EnterEmail(globaldriver);
            _homepage.EnterPassword(globaldriver);
            _homepage.ClickSignInButton(globaldriver);
            _homepage.GotoURL(globaldriver);
            _detailpage.ClickMore(globaldriver);



        }

        
        
    }
}
