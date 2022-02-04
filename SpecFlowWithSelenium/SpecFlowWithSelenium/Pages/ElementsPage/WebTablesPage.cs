using OpenQA.Selenium;
using SpecFlowWithSelenium.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowWithSelenium.Pages
{
    public class WebTablesPage : BasePage
    {
        public WebTablesPage(IWebDriver driver) : base(driver) { }

        #region Add new User 

        public IWebElement FirstNameInputField => Driver.FindElement(By.Id("firstName"));

        public IWebElement LastNameInputField => Driver.FindElement(By.Id("lastName"));

        public IWebElement EmailInputField => Driver.FindElement(By.Id("userEmail"));

        public IWebElement AgeInputField => Driver.FindElement(By.Id("age"));

        public IWebElement SalaryInputField => Driver.FindElement(By.Id("salary"));

        public IWebElement DepartamentInputField => Driver.FindElement(By.Id("department"));

        public IWebElement SubmitButton => Driver.FindElement(By.Id("submit"));

        public IWebElement AddNewUserButton => Driver.FindElement(By.Id("addNewRecordButton"));

        #endregion

        public IWebElement SearchBox => Driver.FindElement(By.Id("searchBox"));
        public IWebElement SearchBoxButton => Driver.FindElement(By.Id("basic-addon2"));


        public bool CheckUserInTable(string name)
        {
            var element = Driver.FindElement(By.XPath($"//*[contains(text(),'{name}')]"));
            if (element.Displayed)
                return true;
            else
                return false;

        }

        public void SearchUserInTable(string name)
        {
            SearchBox.SendKeys(name);
            SearchBoxButton.Click();
        }

        public void SendFirstName(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.FirstName);
            }

        }
        public void SendLasttName(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.LastName);
            }

        }
        public void SendDataOfBirth(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.DataOfBirth);
            }

        }
        public void SendAge(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.Age);
            }

        }
        public void SendCurrentAddress(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.CurrentAddress);
            }

        }
        public void SendDepartament(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.Departament);
            }

        }
        public void SendEmail(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.Email);
            }

        }
        public void SendMobile(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.Mobile);
            }

        }
        public void SendSalary(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.Salary);
            }

        }
        public void SendSubjects(IWebElement element, Table table)
        {
            var form = table.CreateSet<WebTablesUser>();
            foreach (var item in form)
            {
                element.SendKeys(item.Subjects);
            }

        }



    }
}
