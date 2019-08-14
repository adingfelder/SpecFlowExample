using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumShoppingCart.ScreenModel;

namespace SeleniumShoppingCart
{
    public class LoginTest
    {
        ChromeDriver globaldriver = new ChromeDriver();
        HomePage _homepage = new HomePage();
        MyAccountPage _myAccountPage = new MyAccountPage();


        [Test]
        public void POM_SeleniumTest()
        {
            _homepage.GotoURL(globaldriver);
            _homepage.ClickSignIn(globaldriver);
            _homepage.EnterEmail(globaldriver);
            _homepage.EnterPassword(globaldriver);
            _homepage.ClickSignInButton(globaldriver);
            Assert.AreEqual("planit training", _myAccountPage.getAccountName(globaldriver), "Account Name does not match");
            globaldriver.Quit();
        }
    }
}

