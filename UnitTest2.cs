using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniunUsingCSharpAndNunit.ScreenModel;

namespace UnitTestSpecFlow
{
    public class UnitTest2
    {
        ChromeDriver globaldriver = new ChromeDriver();
        HomePage _homepage = new HomePage();
        MyAccountPage myAccountPage = new MyAccountPage();

        [Test]
        public void POM_SeleniumTest()
        {
            _homepage.GotoURL(globaldriver);
            _homepage.ClickSignIn
        }
    }
}
