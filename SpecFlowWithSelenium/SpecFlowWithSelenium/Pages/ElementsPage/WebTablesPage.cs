using OpenQA.Selenium;

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

        //public IWebElement SortByAsc => Driver.FindElement(By.XPath("//*[@class='rt-th rt-resizable-header-sort-asc-cursor-pointer']"));
        //public IWebElement SortByDesc => Driver.FindElement(By.XPath("//*[@class='rt-th rt-resizable-header-sort-desc-cursor-pointer']"));

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
    }
}
