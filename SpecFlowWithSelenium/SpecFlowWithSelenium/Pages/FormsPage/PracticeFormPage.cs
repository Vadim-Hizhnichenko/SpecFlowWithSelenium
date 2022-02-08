using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowWithSelenium.Models;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowWithSelenium.Pages.FormsPage
{
    public class PracticeFormPage : BasePage
    {
        public PracticeFormPage(IWebDriver driver) : base(driver) { }


        // Input UI fields 
        public IWebElement FirstNameField => Driver.FindElement(By.Id("firstName"));
        public IWebElement LastNameField => Driver.FindElement(By.Id("lastName"));
        public IWebElement EmailField => Driver.FindElement(By.Id("userEmail"));
        public IWebElement MobileField => Driver.FindElement(By.Id("userNumber"));
        public IWebElement DataOfBirth => Driver.FindElement(By.Id("userNumber"));
        public IWebElement CurrentAddressField => Driver.FindElement(By.Id("currentAddress"));

        // Radio button
        public IWebElement GenderMaleField => Driver.FindElement(By.XPath("//*[@for='gender-radio-1']"));
        public IWebElement GenderFemaleField => Driver.FindElement(By.XPath("//*[@for='gender-radio-2']"));
        public IWebElement GenderOtherField => Driver.FindElement(By.XPath("//*[@for='gender-radio-3']"));

        // Check box 
        public IWebElement HobbiesSportsField => Driver.FindElement(By.Id("hobbies-checkbox-1"));
        public IWebElement HobbiesReadingField => Driver.FindElement(By.Id("hobbies-checkbox-2"));
        public IWebElement HobbiesMusicField => Driver.FindElement(By.Id("hobbies-checkbox-3"));

        // Choise file button
        public IWebElement UploadFileButton => Driver.FindElement(By.Id("uploadPicture"));

        //drop down 
        public IWebElement SelectStateField => Driver.FindElement(By.Id("react-select-3-input"));
        public IWebElement SelectCityField => Driver.FindElement(By.Id("react-select-4-input"));

        // submit 
        public IWebElement SubmitButton => Driver.FindElement(By.Id("submit"));

        public IWebElement SubjectsField => Driver.FindElement(By.XPath("//*[@id='subjectsInput']"));
        public IWebElement StateValue => Driver.FindElement(By.XPath("//*[@class=' css-1uccc91-singleValue']"));


        //Modal UI Elements
        #region Modal Window Elements

        public IWebElement ModalWindow => Driver.FindElement(By.XPath("//*[@class='modal-dialog modal-lg']"));

        #endregion
        public void SelectState(string nameState)
        {
            var action = new Actions(Driver);
            SelectStateField.SendKeys(nameState);
            action.MoveToElement(SelectStateField).KeyDown(Keys.Enter).Perform();
        }
        public void SelectCity(string nameCity)
        {
            var action = new Actions(Driver);
            SelectCityField.SendKeys(nameCity);
            action.MoveToElement(SelectStateField).KeyDown(Keys.Enter).Perform();
        }
        public bool DisplayValueState()
        {
            return StateValue.Displayed;
        }
        public IWebElement SelectGender(string genderType)
        {
            return genderType switch
            {
                "Male" => GenderMaleField,
                "Female" => GenderFemaleField,
                "Other" => GenderOtherField,
                _ => GenderMaleField,
            };
            ;
            

        }
         
        public void SelectGenderType(IWebElement element)
        {
            element.Click();
        }

        // TODO     
        public void GetDataBirth()
        {
            var month = Driver.FindElement(By.XPath("//*[@class='react-datepicker__month-select']"));
            SelectElement listMonth = new SelectElement(month);
            listMonth.SelectByText("April");

            var year = Driver.FindElement(By.XPath("//*[@class='react-datepicker__year-select']"));
            SelectElement listYear = new SelectElement(year);
            listYear.SelectByText("1994");

        }
       
    }
    


}
