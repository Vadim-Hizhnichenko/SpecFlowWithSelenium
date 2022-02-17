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
        private readonly AutoCompletePage _autoCompletePage;
        private readonly DatePicker _datePicker;
        private readonly Driver _driver;

        public WidgetsStep(Driver driver)
        {
            _driver = driver;
            _accordianPage = new AccordianPage(driver.Current);
            _autoCompletePage = new AutoCompletePage(driver.Current);
            _datePicker = new DatePicker(driver.Current);
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

        #region AutoComplete Methods Tests

        [When(@"We send color '(.*)'")]
        public void WhenWeSendColor(string colorName)
        {
            _autoCompletePage.SendColor(colorName, _autoCompletePage.MyltipleColorInput);
           
        }

        [When(@"See the color '(.*)' in the input field")]
        public void WhenSeeTheColorInTheInputField(string colorName)
        {
            Assert.AreEqual(colorName, _autoCompletePage.ColorResult.Text);
        }

        [When(@"We send singl color '(.*)'")]
        public void WhenWeSendSinglColor(string colorName)
        {
            _autoCompletePage.SendColor(colorName, _autoCompletePage.SinglColorInput);
        }

        [When(@"See the color '(.*)'")]
        public void WhenSeeTheColor(string colorName)
        {
            Assert.AreEqual(colorName, _autoCompletePage.SinglColorResult.Text);
        }

        #endregion

        #region Date Picker Method Tests

        [When(@"Select date '(.*)'")]
        public void WhenSelectDate(string date)
        {
            _datePicker.SelectDate(date);
        }

        [When(@"See this date")]
        public void WhenSeeThisDate()
        {
            Assert.IsTrue(_datePicker.SelectDataInput.Displayed);
        }

        [When(@"Select date with time '(.*)'")]
        public void WhenSelectDateWithTime(string dateAndTime)
        {
            _datePicker.SelectDateAndTime(dateAndTime);
        }

        [When(@"See this date with time")]
        public void WhenSeeThisDateWithTime()
        {
            Assert.IsTrue(_datePicker.SelectDateAndTimeInput.Displayed);
        }


        #endregion
    }
}
