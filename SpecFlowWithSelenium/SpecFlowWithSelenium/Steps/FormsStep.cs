using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowWithSelenium.Support;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public sealed class FormsStep
    {
        private readonly FormsPagesFactory _pageFactory;

        public FormsStep(FormsPagesFactory pageFactory)
        {
            _pageFactory = pageFactory;
        }

        [When(@"Select tate and city")]
        public void WhenSelectTateAndCity()
        {

            var x = _pageFactory.Driver.FindElement(By.Id("react-select-3-input"));
            var action = new Actions(_pageFactory.Driver);
            x.SendKeys("NCR");
            action.MoveToElement(x).KeyDown(Keys.Enter).Perform();


        }

    }
}
