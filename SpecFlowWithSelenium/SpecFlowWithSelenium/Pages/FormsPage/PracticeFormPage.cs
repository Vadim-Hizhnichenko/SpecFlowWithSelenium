using OpenQA.Selenium;
using System.Linq;
using System.Threading;

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
        public IWebElement GenderMaleField => Driver.FindElement(By.Id("gender-radio-1"));
        public IWebElement GenderFemaleField => Driver.FindElement(By.Id("gender-radio-2"));
        public IWebElement GenderOtherField => Driver.FindElement(By.Id("gender-radio-3"));

        // Check box 
        public IWebElement HobbiesSportsField => Driver.FindElement(By.Id("hobbies-checkbox-1"));
        public IWebElement HobbiesReadingField => Driver.FindElement(By.Id("hobbies-checkbox-2"));
        public IWebElement HobbiesMusicField => Driver.FindElement(By.Id("hobbies-checkbox-3"));

        // Choise file button
        public IWebElement UploadFileButton => Driver.FindElement(By.Id("uploadPicture"));

        //drop down 
        public IWebElement SelectStateField => Driver.FindElement(By.Id("react-select-3-input"));
        public IWebElement SelectCityField => Driver.FindElement(By.Id("city"));

        // submit 
        public IWebElement SubmitButton => Driver.FindElement(By.Id("submit"));



    }
    


}
