using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // For debugging - Should be removed - No sleeps should be in the code
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumShoppingCart.ScreenModel;

namespace SeleniumShoppingCart
{
    [TestFixture]
    public class SearchTShirts
    {
        ChromeDriver globaldriver;
        HomePage _homepage = new HomePage();
        TShirtsDetails _tshirts = new TShirtsDetails();

        [SetUp]
        public void SetupTest()
        {

            globaldriver = new ChromeDriver();


        }




        [Test]
        public void Login_is_on_home_page()
        {




            _homepage.GotoURL(globaldriver);
            _tshirts.ClickTShirtsTab(globaldriver);
            _tshirts.ClickMoreButton(globaldriver);
            _tshirts.AddAShirt(globaldriver);

            _tshirts.FindSizeTab(globaldriver);

            _tshirts.PickSize(globaldriver);
            _tshirts.PickMSize(globaldriver);

            _tshirts.PickBlueColour(globaldriver);

            _tshirts.AddToCart(globaldriver);



        }

        [TearDown]
        public void TearDownTest()
        {
            globaldriver.Close();
        }




    }


}
