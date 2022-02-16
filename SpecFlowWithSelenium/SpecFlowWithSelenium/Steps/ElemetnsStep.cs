using NUnit.Framework;
using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public sealed class ElemetnsStep
    {

        //private readonly ElementsPagesFactory _pageFactory;
        private readonly TextBoxPage _textBoxPage;
        private readonly CheckBox _checkBox;
        private readonly RadioButtonPage _radioButtonPage;
        private readonly WebTablesPage _webTablesPage;
        private readonly ButtonsPage _buttonsPage;
        private readonly LinksPage _linksPage;
        private readonly BrokenLinkPage _brokenLinkPage;
        private readonly UploadAndDownloadPage _uploadAndDownloadPage;
        private readonly DynamicPropertiesPage _dynamicPropertiesPage;
        private readonly Driver _driver;

        public ElemetnsStep(Driver driver)
        {
            _driver = driver;
            _textBoxPage = new TextBoxPage(driver.Current);
            _checkBox = new CheckBox(driver.Current);
            _radioButtonPage = new RadioButtonPage(driver.Current);
            _buttonsPage = new ButtonsPage(driver.Current);
            _webTablesPage = new WebTablesPage(driver.Current);
            _linksPage = new LinksPage(driver.Current);
            _brokenLinkPage = new BrokenLinkPage(driver.Current);
            _uploadAndDownloadPage = new UploadAndDownloadPage(driver.Current);
            _dynamicPropertiesPage = new DynamicPropertiesPage(driver.Current);
        }

        

        [Given(@"I have base url site")]
        public void GivenIHaveBaseUrlSite()
        {
            _textBoxPage.NavigateToUrl(ProjectSettings.BaseUrl);
        }

        [When(@"I go to url '(.*)'")]
        public void WhenIGoToUrl(string endPoint)
        {
            _textBoxPage.NavigateToUrl(ProjectSettings.BaseUrl + endPoint);
        }

        [When(@"Use button chebox")]
        public void WhenUseButtonChebox()
        {
            _checkBox.SelectAllFileElement.Click();
        }

        [When(@"Fill the form and submit date next data")]
        public void WhenFillTheFormAndSubmitDateNextData(Table table)
        {

            _textBoxPage.SendFullNameUser(_textBoxPage.UserNameInputField, table);
            _textBoxPage.SendEmail(_textBoxPage.EmailInputField, table);
            _textBoxPage.SendCurrentAddress(_textBoxPage.CurrentAddressInputField, table);
            _textBoxPage.SendPermanentAddress(_textBoxPage.PermanentAddressinputField, table);

            _textBoxPage.SubmitButton.Click();
        }

        #region Web Tables Test Methods
        [When(@"I click button Add")]
        public void WhenIClickButtonAdd()
        {
            _webTablesPage.AddNewUserButton.Click();
        }


        [When(@"I create new user")]
        public void WhenICreateNewUser(Table table)
        {
            _webTablesPage.SendFirstName(_webTablesPage.FirstNameInputField, table);
            _webTablesPage.SendLasttName(_webTablesPage.LastNameInputField, table);
            _webTablesPage.SendAge(_webTablesPage.AgeInputField, table);
            _webTablesPage.SendEmail(_webTablesPage.EmailInputField, table);
            _webTablesPage.SendSalary(_webTablesPage.SalaryInputField, table);
            _webTablesPage.SendDepartament(_webTablesPage.DepartamentInputField, table);
            _webTablesPage.SubmitButton.Click();
        }

        [When(@"Search created user with name '(.*)'")]
        public void WhenSearchCreatedUserWithName(string name)
        {
            _webTablesPage.SearchUserInTable(name);
            Assert.IsTrue(_webTablesPage.CheckUserInTable(name));

        }
        #endregion

        #region Radio Button test Methods
        [When(@"use radio button Impressive")]
        public void WhenUseRadioButtonImpressive()
        {
            _radioButtonPage.ImpressiveRadioButton.Click();
        }

        [When(@"use radio button Yes")]
        public void WhenUseRadioButtonYes()
        {
            _radioButtonPage.YesRadioButton.Click();
        }


        [When(@"We see selected this text '(.*)'")]
        public void WhenWeSeeSelectedThisText(string buttonText)
        {
            Assert.AreEqual(buttonText, _radioButtonPage.ImpressiveRadioButton.Text);
        }

        [When(@"We see selected text '(.*)'")]
        public void WhenWeSeeSelectedText(string buttonText)
        {
            Assert.AreEqual(buttonText, _radioButtonPage.YesRadioButton.Text);
        }



        #endregion


        [When(@"I click three buttons")]
        public void WhenIClickThreeButtons()
        {
            _buttonsPage.ClickMeButton.Click();
            _buttonsPage.DoRightClick();
            _buttonsPage.DoDoubleClick();

        }

        [When(@"I click to link")]
        public void WhenIClickToLink()
        {
            _linksPage.HomeLink.Click();

        }

        #region Click Link Test Methods

        [When(@"I click Created link")]
        public void WhenIClickCreatedLink()
        {
            _linksPage.CreatedLink.Click();
        }

        [When(@"I click No Content link")]
        public void WhenIClickNoContentLink()
        {
            _linksPage.NoContentLink.Click();
        }

        [When(@"I click Moved link")]
        public void WhenIClickMovedLink()
        {
            _linksPage.MovedLink.Click();
        }

        [When(@"I click Bad Request link")]
        public void WhenIClickBadRequestLink()
        {
            _linksPage.BadRequestLink.Click();
        }

        [When(@"I click Unauthorized link")]
        public void WhenIClickUnauthorizedLink()
        {
            _linksPage.UnauthorizedLink.Click();
        }

        [When(@"I click Forbidden link")]
        public void WhenIClickForbiddenLink()
        {
            _linksPage.ForbiddenLink.Click();
        }

        [When(@"I click NotFound link")]
        public void WhenIClickNotFoundLink()
        {
            _linksPage.NotFountLink.Click();
        }

        [When(@"See result text on disply")]
        public void WhenSeeResultTextOnDisply()
        {
            Assert.IsTrue(_linksPage.LinkResponse.Displayed);
        }

        [When(@"New tab with site opened")]
        public void WhenNewTabWithSiteOpened()
        {
            _linksPage.SwitchWindow();
            Assert.AreEqual("ToolsQA", _linksPage.Title);
        }

        [When(@"I click to dynamic link")]
        public void WhenIClickToDynamicLink()
        {
            _linksPage.HomeDynamicLink.Click();
        }

        #endregion

        #region Broken Link Test Methods

        [When(@"I click valid link")]
        public void WhenIClickValidLink()
        {
            _brokenLinkPage.ValidLink.Click();
        }

        [When(@"I click invalid link")]
        public void WhenIClickInvalidLink()
        {
            _brokenLinkPage.BrokenLink.Click();
        }

        [When(@"I redirected to home page")]
        public void WhenIRedirectedToHomePage()
        {
            Assert.AreEqual("ToolsQA", _linksPage.Title);
        }

        [When(@"I was redirected to error page")]
        public void WhenIWasRedirectedToErrorPage()
        {
            Assert.IsTrue(_brokenLinkPage.AnwerBrokenLink.Displayed);
        }

        #endregion

        #region Upload And Download file Test Methods
        [When(@"Click button download file")]
        public void WhenClickButtonDownloadFile()
        {
            _uploadAndDownloadPage.DownloadButton.Click();
        }

        [When(@"I see this file to the download folder")]
        public void WhenISeeThisFileToTheDownloadFolder()
        {
            string fileName = "sampleFile.jpeg";
            Assert.IsTrue(_uploadAndDownloadPage.CheckFile(fileName));
        }

        [When(@"I click upload button and select file to upload '(.*)'")]
        public void WhenIClickUploadButtonAndSelectFileToUpload(string pathFile)
        {
            _uploadAndDownloadPage.UploadButton.SendKeys(pathFile);
        }


        [When(@"The path of the loaded file is visible")]
        public void WhenThePathOfTheLoadedFileIsVisible()
        {
            Assert.IsTrue(_uploadAndDownloadPage.UploadFilePath.Displayed);
        }

        #endregion

        [When(@"The buttons become enable and visible")]
        public void WhenTheButtonsBecomeEnableAndVisible()
        {
            Assert.IsTrue(_dynamicPropertiesPage.EnableButton.Displayed);
            Assert.IsTrue(_dynamicPropertiesPage.ChangeColorButton.Displayed);
            Assert.IsTrue(_dynamicPropertiesPage.VisibleButton.Displayed);

        }


        [When(@"I see three message")]
        public void WhenISeeThreeMessage()
        {
            Assert.IsTrue(_buttonsPage.ClickMeMessage.Displayed);
            Assert.IsTrue(_buttonsPage.RightClickMeMessage.Displayed);
            Assert.IsTrue(_buttonsPage.DoubleClickMeMessage.Displayed);
        }


        [When(@"I see our date")]
        public void WhenISeeOurDate()
        {
            Assert.IsTrue(_textBoxPage.NameCheck.Displayed);
            Assert.IsTrue(_textBoxPage.EmailCheck.Displayed);
            Assert.IsTrue(_textBoxPage.CurrentAddressCheck.Displayed);
            Assert.IsTrue(_textBoxPage.PermanentAddressCheck.Displayed);
        }

        [When(@"I see text in window")]
        public void WhenISeeTextInWindow()
        {
            Assert.IsTrue(_checkBox.SpanTextElement.Displayed);
        }


        [Then(@"We closed browser")]
        public void ThenWeClosedBrowser()
        {
            _driver.Dispose();
        }



    }
}
