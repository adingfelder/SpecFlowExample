using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniunUsingCSharpAndNunit.ScreenModel;

namespace SeleniunUsingCSharpAndNunit
{
    public class UnitTest1
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
            string actualValue = _myAccountPage.getAccountName(globaldriver);
            Assert.AreEqual("planit training", actualValue, "Account Name does not match");
            globaldriver.Quit();
        }
    }
}

