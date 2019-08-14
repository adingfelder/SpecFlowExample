using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSpecFlow
{
    class CreditSlip
    {
        private IWebDriver driver;

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

    }
}

