using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MyCalculator;
using NUnit.Framework;


namespace SpecflowNUnitDemo.Step_Definitions
{
    [Binding]
    class CalculatorSteps
    {


        private readonly Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numEntered)
        {
            calculator.numbers.Add(numEntered);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculator.total);
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            calculator.Divide();
        }

    }
}
