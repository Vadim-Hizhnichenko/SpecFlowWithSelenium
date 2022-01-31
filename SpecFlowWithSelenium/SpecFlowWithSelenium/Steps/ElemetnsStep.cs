using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using SpecFlowWithSelenium.Models;
using SpecFlowWithSelenium.Pages;
using SpecFlowWithSelenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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

        [When(@"Fill the form and submit date next data")]
        public void WhenFillTheFormAndSubmitDateNextData(Table table)
        {

            var form = table.CreateSet<TextBoxForm>();

            foreach (var item in form)
            {
                _pageFactory.TextBoxPage.UserNameInputField.SendKeys(item.FullName);
                _pageFactory.TextBoxPage.EmailInputField.SendKeys(item.Email);
                _pageFactory.TextBoxPage.CurrentAddressInputField.SendKeys(item.CurrentAddress);
                _pageFactory.TextBoxPage.PermanentAddressinputField.SendKeys(item.PermanentAddress);

            }

            _pageFactory.TextBoxPage.SubmitButton.Click();
        }

        [When(@"I click button Add")]
        public void WhenIClickButtonAdd()
        {
            _pageFactory.WebTablesPage.AddNewUserButton.Click();
        }


        [When(@"I create new user")]
        public void WhenICreateNewUser(Table table)
        {
            var form = table.CreateSet<WebTablesUser>();

            foreach (var item in form)
            {
                _pageFactory.WebTablesPage.FirstNameInputField.SendKeys(item.FirstName);
                _pageFactory.WebTablesPage.LastNameInputField.SendKeys(item.LastName);
                _pageFactory.WebTablesPage.AgeInputField.SendKeys(item.Age);
                _pageFactory.WebTablesPage.EmailInputField.SendKeys(item.Email);
                _pageFactory.WebTablesPage.SalaryInputField.SendKeys(item.Salary);
                _pageFactory.WebTablesPage.DepartamentInputField.SendKeys(item.Departament);
            }

            _pageFactory.WebTablesPage.SubmitButton.Click();
        }

        [When(@"Search created user with name '(.*)'")]
        public void WhenSearchCreatedUserWithName(string name)
        {
            _pageFactory.WebTablesPage.SearchUserInTable(name);
            Assert.IsTrue(_pageFactory.WebTablesPage.CheckUserInTable(name));
        }


        [When(@"use radio button Impressive")]
        public void WhenUseRadioButtonImpressive()
        {
            _pageFactory.RadioButtonPage.ImpressiveRadioButton.Click();
        }

        [When(@"use radio button Yes")]
        public void WhenUseRadioButtonYes()
        {
            _pageFactory.RadioButtonPage.YesRadioButton.Click();
        }


        [When(@"We see selected text '(.*)'")]
        public void WhenWeSeeSelectedText(string buttonText)
        {
            Assert.AreEqual(buttonText, _pageFactory.RadioButtonPage.YesRadioButton.Text);
        }

        [When(@"I click three buttons")]
        public void WhenIClickThreeButtons()
        {
            var act = new Actions(_pageFactory.Driver);
            _pageFactory.ButtonsPage.ClickMeButton.Click();
            act.ContextClick(_pageFactory.ButtonsPage.RightClickMeButton).Perform();
            act.DoubleClick(_pageFactory.ButtonsPage.DoubleClickMeButton).Perform();
            
            
        }

        [When(@"I click to link")]
        public void WhenIClickToLink()
        {
            _pageFactory.LinksPage.HomeLink.Click();
            _pageFactory.LinksPage.HomeDynamicLink.Click();
            
            
        }

        [When(@"New tab with site opened")]
        public void WhenNewTabWithSiteOpened()
        {
            _pageFactory.Driver.SwitchTo().Window(_pageFactory.Driver.WindowHandles.Last());
            Assert.AreEqual("ToolsQA", _pageFactory.LinksPage.Title);
            _pageFactory.Driver.SwitchTo().Window(_pageFactory.Driver.WindowHandles[1]);
            Assert.AreEqual("ToolsQA", _pageFactory.LinksPage.Title);
        }


        [When(@"I see three message")]
        public void WhenISeeThreeMessage()
        {
            Assert.IsTrue(_pageFactory.ButtonsPage.ClickMeMessage.Displayed);
            Assert.IsTrue(_pageFactory.ButtonsPage.RightClickMeMessage.Displayed);
            Assert.IsTrue(_pageFactory.ButtonsPage.DoubleClickMeMessage.Displayed);
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
