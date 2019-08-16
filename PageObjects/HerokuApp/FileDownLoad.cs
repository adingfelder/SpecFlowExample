using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    class FileDownLoad
    {
        public By ClickingFileDownload = By.XPath("//li[17]//a[1]");
        public By ClickingSimpleTxt = By.XPath("//a[contains(text(),'simple.txt')]");
        public By ClickingSomeFileTxt = By.XPath("//a[contains(text(),'some-file.txt')]");
        public By ClickingScreenShot = By.XPath("//a[contains(text(),'Screen Shot 2019-08-06 at 10.13.36 AM.png')]");

        //Method to click the button 
        public void ClickFileDownload(IWebDriver driver)
        {
            driver.FindElement(ClickingFileDownload).Click();
        }

        public void ClickSimpleTxt(IWebDriver driver)
        {
            driver.FindElement(ClickingSimpleTxt).Click();
        }
        public void ClickSomeTxtFile(IWebDriver driver)
        {
            driver.FindElement(ClickingSomeFileTxt).Click();
        }
        public void ClickScreenShot(IWebDriver driver)
        {
            driver.FindElement(ClickingScreenShot).Click();
        }


    }
}
