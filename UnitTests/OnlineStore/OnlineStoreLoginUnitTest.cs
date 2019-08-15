using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumShoppingCart.ScreenModel;
using System;

namespace SeleniumShoppingCart
{
    public class LoginTest
    {
        ChromeDriver globaldriver;  //= new ChromeDriver();
        HomePage _homepage = new HomePage();
        MyAccountPage _myAccountPage = new MyAccountPage();

        [SetUp]
        public void SetupTest()
        {
            Console.WriteLine("doing TestLogin setup");
            // homeurl is set in HomePage class
            //homeURL = "http://automationpractice.com/index.php";
            globaldriver = new ChromeDriver();
        }

        [Test]
        public void TestLogin()
        {
            Console.WriteLine("doing TestLogin");
            _homepage.GotoURL(globaldriver);
            _homepage.ClickSignIn(globaldriver);
            _homepage.EnterEmail(globaldriver);
            _homepage.EnterPassword(globaldriver);
            _homepage.ClickSignInButton(globaldriver);
            Assert.AreEqual("planit training", _myAccountPage.getAccountName(globaldriver), "Account Name does not match");
            globaldriver.Close();
            Console.WriteLine("TestLogin closed");

        }

        [Test]
        public void TestLogin2()
        {
            Console.WriteLine("doing TestLogin2");
            _homepage.GotoURL(globaldriver);
            _homepage.ClickSignIn(globaldriver);
            _homepage.EnterEmail(globaldriver);
            _homepage.EnterPassword(globaldriver);
            _homepage.ClickSignInButton(globaldriver);
            Assert.AreEqual("planit training", _myAccountPage.getAccountName(globaldriver), "Account Name does not match");
            globaldriver.Close();
            Console.WriteLine("TestLogin2 closed");
        }

        [TearDown]
        public void TearDownTest()
        {
            Console.WriteLine("doing login teardown - quit");
            globaldriver.Quit();
            //agnes doesnt like not having a tick
        }

    }
}

