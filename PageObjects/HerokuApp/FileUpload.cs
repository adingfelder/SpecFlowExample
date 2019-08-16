using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.HerokuApp
{
    /// <summary>
    /// Summary description for DropDownBox
    /// </summary>
    [TestClass]
    public class FileUpload
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public By ClickFileUpload = By.XPath("//*[@id=\"content\"]/ul/li[18]/a");
        public By ChooseFile = By.Id("file-upload");
        public By Upload = By.Id("file-submit");


        public void ClickingFileUpload(IWebDriver driver)
        {
            driver.FindElement(ClickFileUpload).Click();
            

        }



        public bool ChoosingFile(IWebDriver driver)
        {
            log.Info("finding file chooser");
            driver.FindElement(ChooseFile).Click();
            //IWebElement chooser = driver.FindElement(ChooseFile);
            //chooser.Click();

            // hard coding to a single file for now
            string path = @"c:\temp\MyTest.txt";

            // Create the file.
            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            //string curFile = @"C:\\Users\\szhang\\Downloads\\CV Items\\planitCVTemplate.dotx";
            //string curFile = "TextFile1";
            if (File.Exists(path))
            {
                log.Debug("File " + path + " exists");
                Task.Delay(2000).Wait();
                //log.Info("want file: " + path);
                SendKeys.SendWait(path);
                Task.Delay(2000).Wait();
                log.Debug("added " + path);
                log.Debug("sending enter");
                SendKeys.SendWait(@"{Enter}");
                log.Debug("sent enter");

                // TODO  We need to check if this closed the box

                return true;
            }
            else
            {
                log.Warn("File "+ path + " does not exist.");
                return false;
            }
           
        }

        public void UploadFile(IWebDriver driver)
        {
            driver.FindElement(Upload).Click();
        }



    }
}

