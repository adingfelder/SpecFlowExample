using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniunUsingCSharpAndNunit.ScreenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UnitTestSpecFlow.PageObjects.OnlineStore;

namespace UnitTestSpecFlow.Step_Definitions
{
    [Binding]
    class ViewDetailStep
    {
        ChromeDriver globaldriver;
        HomePage _homepage;
        ViewDetailPage _detailPage;

        public ViewDetailStep()
        {
            globaldriver = new ChromeDriver();
            _homepage = new HomePage();
            _detailPage = new ViewDetailPage();
        }

        [Given(@"I am on the store page")]
        public void GivenIAmOnTheHomePage()
        {
            _homepage.GotoURL(globaldriver);
        }

        [When(@"I click an item")]
        public void WhenIClickAnItem()
        {
            _detailPage.ClickMore(globaldriver);
        }

        [Then(@"I should see item details")]
        public void ThenIShouldSeeItemDetails()
        {
            Assert.AreEqual("Faded short sleeve t-shirt with high neckline. Soft and stretchy material for a comfortable fit. Accessorize with a straw hat and you're ready for summer!", _detailPage.GetItemDetail(globaldriver), "Wrong item");
        }

    }
}
