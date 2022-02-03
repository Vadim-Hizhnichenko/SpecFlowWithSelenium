using OpenQA.Selenium;
using SpecFlowWithSelenium.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowWithSelenium.Pages
{
    public class TextBoxPage : BasePage
    {
        public TextBoxPage(IWebDriver driver) : base(driver) { }


        // TextBox Panel
        public IWebElement ElementPanel => Driver.FindElement(By.XPath("//*[@id='item-0']"));

        // Input UI elements
        public IWebElement UserNameInputField => Driver.FindElement(By.Id("userName"));
        public IWebElement EmailInputField => Driver.FindElement(By.Id("userEmail"));
        public IWebElement CurrentAddressInputField => Driver.FindElement(By.Id("currentAddress"));
        public IWebElement PermanentAddressinputField => Driver.FindElement(By.Id("permanentAddress"));

        public IWebElement SubmitButton => Driver.FindElement(By.Id("submit"));

        // UI fields to check
        public IWebElement NameCheck => Driver.FindElement(By.Id("name"));
        public IWebElement EmailCheck => Driver.FindElement(By.Id("email"));
        public IWebElement CurrentAddressCheck => Driver.FindElement(By.Id("currentAddress"));
        public IWebElement PermanentAddressCheck => Driver.FindElement(By.Id("permanentAddress"));

        public void NavigateToUrl(string url)
        {
            Navigate(url);
        }

        public void SendFullNameUser(IWebElement element, Table table)
        {
            var form = table.CreateSet<TextBoxForm>();
            foreach (var item in form)
            {
                element.SendKeys(item.FullName);
            }
         
        }
        
        // to do  
        // method for email
        // method for address perm
        // method for addr cur
        
    }
}
