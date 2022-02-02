using OpenQA.Selenium;

namespace SpecFlowWithSelenium.Pages
{
    public class BasePage
    {
        protected BasePage(IWebDriver driver) => Driver = driver;

        protected IWebDriver Driver { get; }

        protected void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

       
    }
}
