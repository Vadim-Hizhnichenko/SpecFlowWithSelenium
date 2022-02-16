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
            _practiceFormPage.ClickElement(_practiceFormPage.SelectGender(genderType));
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


        [When(@"Input date of birth  month '(.*)' year '(.*)' day '(.*)'")]
        public void WhenInputDateOfBirthMonthYearDay(string month, string year, string day)
        {
            _practiceFormPage.GetDataBirth(month, year, day);
        }


        [When(@"See result date with data")]
        public void WhenSeeResultDateWithData()
        {
            Assert.IsTrue(_practiceFormPage.CalendarField.Displayed);
        }

        [When(@"Select hobbie '(.*)'")]
        public void WhenSelectHobbie(string hobbie)
        {
            _practiceFormPage.GetHobbie(hobbie);
        }

        [When(@"Hobbie '(.*)' was selected")]
        public void WhenHobbieWasSelected(string result)
        {
            Assert.AreEqual(_practiceFormPage.HobbiesSportsField.Text, result);
        }

        [When(@"Click to Submit")]
        public void WhenClickToSubmit()
        {

            _practiceFormPage.ClickSubmitButton();
        }


        [When(@"Checking the entered data")]
        public void WhenCheckingTheEnteredData()
        {
            _driver.Current.SwitchTo().ActiveElement();
        }


    }
}
