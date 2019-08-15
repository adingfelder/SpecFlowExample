using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    /// <summary>
    
    /// </summary>
    [TestClass]
    public class FileUpload
    {
        public By ClickFileUpload = By.XPath("//*[@id=\"content\"]/ul/li[18]/a");
        public By ChooseFile = By.Id("file-upload");
        public By Upload = By.Id("file-submit");







        public void ClickingFileUpload(IWebDriver driver)
        {
            driver.FindElement(ClickFileUpload).Click();
            

        }

        public void ChoosingFile(IWebDriver driver)
        {
            driver.FindElement(ChooseFile).Click();
            SendKeys.SendWait(@"C:\Users\szhang\Downloads\CV Items\planitCVTemplate.dotx");
            SendKeys.SendWait(@"{Enter}");
        }
        public void UploadFile(IWebDriver driver)
        {
            driver.FindElement(Upload).Click();
        }



    }
}

