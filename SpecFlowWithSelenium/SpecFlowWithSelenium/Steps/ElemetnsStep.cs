using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowWithSelenium.Models;
using SpecFlowWithSelenium.Support;
using System;
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

        [Given(@"I have base url site")]
        public void GivenIHaveBaseUrlSite()
        {
            _pageFactory.TextBoxPage.NavigateToUrl(ProjectSettings.BaseUrl);
        }

        [When(@"I go to url '(.*)'")]
        public void WhenIGoToUrl(string endPoint)
        {
            _pageFactory.TextBoxPage.NavigateToUrl(ProjectSettings.BaseUrl + endPoint);
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


        [When(@"We see selected this text '(.*)'")]
        public void WhenWeSeeSelectedThisText(string buttonText)
        {
            Assert.AreEqual(buttonText, _pageFactory.RadioButtonPage.ImpressiveRadioButton.Text);
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
                      
        }

        #region Click Link Test Methods

        [When(@"I click Created link")]
        public void WhenIClickCreatedLink()
        {
            _pageFactory.LinksPage.CreatedLink.Click();
        }

        [When(@"I click No Content link")]
        public void WhenIClickNoContentLink()
        {
            _pageFactory.LinksPage.NoContentLink.Click();
        }

        [When(@"I click Moved link")]
        public void WhenIClickMovedLink()
        {
            _pageFactory.LinksPage.MovedLink.Click();
        }

        [When(@"I click Bad Request link")]
        public void WhenIClickBadRequestLink()
        {
            _pageFactory.LinksPage.BadRequestLink.Click();
        }

        [When(@"I click Unauthorized link")]
        public void WhenIClickUnauthorizedLink()
        {
            _pageFactory.LinksPage.UnauthorizedLink.Click();
        }

        [When(@"I click Forbidden link")]
        public void WhenIClickForbiddenLink()
        {
            _pageFactory.LinksPage.ForbiddenLink.Click();
        }

        [When(@"I click NotFound link")]
        public void WhenIClickNotFoundLink()
        {
            _pageFactory.LinksPage.NotFountLink.Click();
        }

        [When(@"See result text on disply")]
        public void WhenSeeResultTextOnDisply()
        {
            Assert.IsTrue(_pageFactory.LinksPage.LinkResponse.Displayed);
        }

        [When(@"New tab with site opened")]
        public void WhenNewTabWithSiteOpened()
        {
            _pageFactory.Driver.SwitchTo().Window(_pageFactory.Driver.WindowHandles.Last());
            Assert.AreEqual("ToolsQA", _pageFactory.LinksPage.Title);

        }

        [When(@"I click to dynamic link")]
        public void WhenIClickToDynamicLink()
        {
            _pageFactory.LinksPage.HomeDynamicLink.Click();
        }

        #endregion

        #region Broken Link Test Methods

        [When(@"I click valid link")]
        public void WhenIClickValidLink()
        {
            _pageFactory.BrokenLinkPage.ValidLink.Click();
        }

        [When(@"I click invalid link")]
        public void WhenIClickInvalidLink()
        {
            _pageFactory.BrokenLinkPage.BrokenLink.Click();
        }

        [When(@"I redirected to home page")]
        public void WhenIRedirectedToHomePage()
        {
            Assert.AreEqual("ToolsQA", _pageFactory.LinksPage.Title);
        }

        [When(@"I was redirected to error page")]
        public void WhenIWasRedirectedToErrorPage()
        {
            Assert.IsTrue(_pageFactory.BrokenLinkPage.AnwerBrokenLink.Displayed);
        }

        #endregion

        #region Upload And Download file Test Methods
        [When(@"Click button download file")]
        public void WhenClickButtonDownloadFile()
        {
            _pageFactory.UploadAndDownloadPage.DownloadButton.Click();
        }

        [When(@"I see this file to the download folder")]
        public void WhenISeeThisFileToTheDownloadFolder()
        {
            string fileName = "sampleFile.jpeg";
            Assert.IsTrue(_pageFactory.UploadAndDownloadPage.CheckFile(fileName));
        }

        [When(@"I click upload button and select file to upload '(.*)'")]
        public void WhenIClickUploadButtonAndSelectFileToUpload(string pathFile)
        {
            _pageFactory.UploadAndDownloadPage.UploadButton.SendKeys(pathFile);
        }


        [When(@"The path of the loaded file is visible")]
        public void WhenThePathOfTheLoadedFileIsVisible()
        {
            Assert.IsTrue(_pageFactory.UploadAndDownloadPage.UploadFilePath.Displayed);
        }

        #endregion

        [When(@"The buttons become enable and visible")]
        public void WhenTheButtonsBecomeEnableAndVisible()
        {
            Assert.IsTrue(_pageFactory.DynamicPropertiesPage.EnableButton.Displayed);
            Assert.IsTrue(_pageFactory.DynamicPropertiesPage.ChangeColorButton.Displayed);
            Assert.IsTrue(_pageFactory.DynamicPropertiesPage.VisibleButton.Displayed);

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
