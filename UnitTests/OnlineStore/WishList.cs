using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;
using System.Threading.Tasks;

namespace SeleniumShoppingCart
{


    [TestFixture]
    public class AddToWishlist
    {
       
        ChromeDriver globaldriver = new ChromeDriver();
        HomePage _homepage = new HomePage();
        MyAccountPage _myAccountPage = new MyAccountPage();


        [Test(Description = "Check SauceLabs Homepage for Login Link")]
        public void WishList()
        {

           

            _homepage.GotoURL(globaldriver);
            _homepage.ClickSignIn(globaldriver);
            _homepage.EnterEmail(globaldriver);
            _homepage.EnterPassword(globaldriver);
            _homepage.ClickSignInButton(globaldriver);

            /*driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("seleniumtraining@gmail.com");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).Clear();
            driver.FindElement(By.Id("passwd")).SendKeys("planit123");
            driver.FindElement(By.Id("SubmitLogin")).Click();*/

            Task.Delay(1000).Wait();


        }




    }


}
