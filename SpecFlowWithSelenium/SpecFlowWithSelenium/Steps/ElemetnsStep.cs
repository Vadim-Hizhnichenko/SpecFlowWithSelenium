using NUnit.Framework;
using OpenQA.Selenium;
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

        [When(@"I go to the panel I need '(.*)'")]
        public void WhenIGoToThePanelINeed(string id)
        {
            _pageFactory.Driver.FindElement(By.Id(id)).Click();
        }

        [When(@"Use button chebox")]
        public void WhenUseButtonChebox()
        {
            _pageFactory.CheckBox.SelectAllFileElement.Click();
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

        [When(@"I see our date")]
        public void WhenISeeOurDate()
        {
            Assert.IsTrue(_pageFactory.TextBoxPage.NameCheck.Displayed);
            Assert.IsTrue(_pageFactory.TextBoxPage.EmailCheck.Displayed);
            Assert.IsTrue(_pageFactory.TextBoxPage.CurrentAddressCheck.Displayed);
            Assert.IsTrue(_pageFactory.TextBoxPage.PermanentAddressCheck.Displayed);
        }

        [When(@"I see text in window")]
        public void WhenISeeTextInWindow()
        {
            Assert.IsTrue(_pageFactory.CheckBox.SpanTextElement.Displayed);
        }


        [Then(@"We closed browser")]
        public void ThenWeClosedBrowser()
        {
            _pageFactory.Driver.Dispose();
        }



    }
}
