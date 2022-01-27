using NUnit.Framework;
using SeleniumExtras.PageObjects;
using SpecFlowWithSelenium.Support;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public sealed class ElemetnsStep
    {

        private readonly PagesFactory _pageFactory;

        public ElemetnsStep(PagesFactory pageFactory)
        {
            _pageFactory = pageFactory;
        }

        [Given(@"I am navigate to website")]
        public void GivenIAmNavigateToWebsite()
        {
            _pageFactory.TextBoxPage.NavigateToUrl(ProjectSettings.ElementsUrl);

        }


        [When(@"I am click to out panel")]
        public void WhenIAmClickToOutPanel()
        {
            _pageFactory.TextBoxPage.ElementPanel.Click();
        }

        [When(@"Fill the form and submit date")]
        public void WhenFillTheFormAndSubmitDate()
        {
            _pageFactory.TextBoxPage.UserNameInputField.SendKeys("Ivan");
            _pageFactory.TextBoxPage.EmailInputField.SendKeys("email@email.com");
            _pageFactory.TextBoxPage.CurrentAddressInputField.SendKeys("current address");
            _pageFactory.TextBoxPage.PermanentAddressinputField.SendKeys("penmanent address");
            _pageFactory.TextBoxPage.SubmitButton.Click();
        }

        [Then(@"I see our date")]
        public void ThenISeeOurDate()
        {
            Assert.IsTrue(_pageFactory.TextBoxPage.NameCheck.Displayed);
            Assert.IsTrue(_pageFactory.TextBoxPage.EmailCheck.Displayed);
            Assert.IsTrue(_pageFactory.TextBoxPage.CurrentAddressCheck.Displayed);
            Assert.IsTrue(_pageFactory.TextBoxPage.PermanentAddressCheck.Displayed);
            _pageFactory.Driver.Dispose();
        }



       
    }
}
