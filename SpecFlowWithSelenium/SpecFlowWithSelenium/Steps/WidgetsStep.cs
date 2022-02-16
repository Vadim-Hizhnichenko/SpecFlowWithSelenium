using NUnit.Framework;
using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages.WidgetsPage;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public sealed class WidgetsStep
    {
        private readonly AccordianPage _accordianPage;
        private readonly Driver _driver;

        public WidgetsStep(Driver driver)
        {
            _driver = driver;
            _accordianPage = new AccordianPage(driver.Current);
        }

        #region Accordian Methods Tests
        [When(@"We click to first accordian button")]
        public void WhenWeClickToFirstAccordianButton()
        {
            _accordianPage.ClickElement(_accordianPage.FirstAccordian);
        }

        [When(@"See the text of this accordian")]
        public void WhenSeeTheTextOfThisAccordian()
        {
            Assert.IsTrue(_accordianPage.FirstAccordianResult.Displayed);
        }

        [When(@"We click to second accordian button")]
        public void WhenWeClickToSecondAccordianButton()
        {
            _accordianPage.ClickElement(_accordianPage.SecondAccordian);
        }

        [When(@"See the text of second accordian")]
        public void WhenSeeTheTextOfSecondAccordian()
        {
            Assert.IsTrue(_accordianPage.SecondAccordianResult.Displayed);
        }

        [When(@"We click to third accordian button")]
        public void WhenWeClickToThirdAccordianButton()
        {
            _accordianPage.ClickElement(_accordianPage.ThirdAccordian);
        }

        [When(@"See the text of last accordian")]
        public void WhenSeeTheTextOfLastAccordian()
        {
            Assert.IsTrue(_accordianPage.ThirdAccordianResult.Displayed);
        }
        #endregion


    }
}
