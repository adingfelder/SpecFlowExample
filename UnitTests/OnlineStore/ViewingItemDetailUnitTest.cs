
using SeleniumShoppingCart.ScreenModel;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace SeleniumShoppingCart
{
   
    public class ViewingItemDetailUnitTest
    {
        ChromeDriver globaldriver = new ChromeDriver();
        HomePage _homepage = new HomePage();
        ViewDetailPage _detailPage = new ViewDetailPage();


        [Test]
        public void POM_SeleniumTest()
        {
            _homepage.GotoURL(globaldriver);
            _detailPage.ClickMore(globaldriver);
            Assert.AreEqual("Faded short sleeve t-shirt with high neckline. Soft and stretchy material for a comfortable fit. Accessorize with a straw hat and you're ready for summer!", 
                _detailPage.GetItemDetail(globaldriver, 
                "Faded short sleeve t-shirt with high neckline. Sof"), 
                "Wrong item");
            globaldriver.Quit();
           

        }


    }
       
        
    
}
