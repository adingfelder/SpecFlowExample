using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniunShoppingCart.ScreenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniunShoppingCart
{
    class CreditSlip
    {
        private IWebDriver driver;
        HomePage _homepage = new HomePage();
        /*
        [SetUp]
        public void SetupTest()
        {

            driver = new ChromeDriver();
            _homepage.GotoURL(driver);
            // _myAccountPage = new ScreenModel.MyAccountPage();
        }


        [Test(Description = "Check for the credit slips button")]
        public void ClickPaySlip()
        {
            driver.FindElement(By.Name("My credit slips"));
        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }
        */

    }
}

