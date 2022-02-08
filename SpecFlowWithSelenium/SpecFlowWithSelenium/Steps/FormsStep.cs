using NUnit.Framework;
using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages;
using SpecFlowWithSelenium.Pages.FormsPage;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public sealed class FormsStep
    {
        private readonly PracticeFormPage _practiceFormPage;
        private readonly WebTablesPage _webTablesPage; 
        private readonly Driver _driver;

        public FormsStep(Driver driver)
        {
            _driver = driver;
            _practiceFormPage = new PracticeFormPage(driver.Current);
            _webTablesPage = new WebTablesPage(driver.Current);
        }


        [When(@"Select State '(.*)'")]
        public void WhenSelectState(string nameState)
        {
            _practiceFormPage.SelectState(nameState);
        }

        [When(@"Selected State are displyaed")]
        public void WhenSelectedStateAreDisplyaed()
        {
            Assert.IsTrue(_practiceFormPage.DisplayValueState());
        }

        [When(@"Choose a city '(.*)'")]
        public void WhenChooseACity(string nameCity)
        {
            _practiceFormPage.SelectCity(nameCity);
        }

        [When(@"City was be displayed")]
        public void WhenCityWasBeDisplayed()
        {
            Assert.IsTrue(_practiceFormPage.DisplayValueState());
        }

        [When(@"Input required user data")]
        public void WhenInputRequiredUserData(Table table)
        {
            _webTablesPage.SendFirstName(_practiceFormPage.FirstNameField, table);
            _webTablesPage.SendLasttName(_practiceFormPage.LastNameField, table);
            _webTablesPage.SendEmail(_practiceFormPage.EmailField, table);
            _webTablesPage.SendMobile(_practiceFormPage.MobileField, table);

        }

        [When(@"Select gender type '(.*)'")]
        public void WhenSelectGenderType(string genderType)
        {
            var x = _practiceFormPage.SelectGender(genderType);
            _practiceFormPage.SelectGenderType(x);
        }

        [When(@"Input required user data and subject")]
        public void WhenInputRequiredUserDataAndSubject(Table table)
        {
            _webTablesPage.SendFirstName(_practiceFormPage.FirstNameField, table);
            _webTablesPage.SendLasttName(_practiceFormPage.LastNameField, table);
            _webTablesPage.SendEmail(_practiceFormPage.EmailField, table);
            _webTablesPage.SendMobile(_practiceFormPage.MobileField, table);
            _webTablesPage.SendSubjects(_practiceFormPage.SubjectsField, table);
        }

    }
}
