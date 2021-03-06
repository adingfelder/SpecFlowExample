﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumShoppingCart.ScreenModel;
using System;
using TechTalk.SpecFlow;

namespace UnitTestSpecFlow.Step_Definitions
{
    

    [Binding]
    public class ViewingDetailSteps
    {
        ChromeDriver globaldriver;
        HomePage _homepage;
        ViewDetailPage _detailPage;
        

        public ViewingDetailSteps()
        {
            globaldriver = new ChromeDriver();
            _homepage = new HomePage();
            _detailPage = new ViewDetailPage();
        }

        [Given(@"Navigate to the homepage")]
        public void GivenNavigateToTheHomepage()
        {
            _homepage.GotoURL(globaldriver);
        }
        
        [When(@"I click an the targeted item")]
        public void WhenIClickAnTheTargetedItem()
        {
            _detailPage.ClickMore(globaldriver);

        }
        
        [Then(@"I should see the targeted Item")]
        public void ThenIShouldSeeTheTargetedItem()
        {
           
            string actual = "Faded short sleeve t-shirt with high neckline. Soft and stretchy material for a comfortable fit. Accessorize with a straw hat and you're ready for summer!";
            string expected = "Faded short sleeve t-shirt with high neckline. Soft and stretchy material for a comfortable fit. Accessorize with a straw hat and you're ready for summer!";
            Assert.AreEqual(expected, _detailPage.GetItemDetail(globaldriver, actual), "Wrong item");
            globaldriver.Quit();
        }
    }
}
