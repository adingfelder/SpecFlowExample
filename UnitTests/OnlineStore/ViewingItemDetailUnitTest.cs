﻿using System;
using System.Text;
using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniunUsingCSharpAndNunit.ScreenModel;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using UnitTestSpecFlow.PageObjects.OnlineStore;

namespace UnitTestSpecFlow.UnitTests.OnlineStore
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
            Assert.AreEqual("Faded short sleeve t-shirt with high neckline. Soft and stretchy material for a comfortable fit. Accessorize with a straw hat and you're ready for summer!", _detailPage.GetItemDetail(globaldriver), "Wrong item");
            globaldriver.Quit();

              

        }


    }
       
        
    
}
