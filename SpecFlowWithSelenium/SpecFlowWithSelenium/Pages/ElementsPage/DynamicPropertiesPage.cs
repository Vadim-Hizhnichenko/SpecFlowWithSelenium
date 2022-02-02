using OpenQA.Selenium;
using SpecFlowWithSelenium.Extensions;

namespace SpecFlowWithSelenium.Pages
{
    public class DynamicPropertiesPage : BasePage
    {
        public DynamicPropertiesPage(IWebDriver driver) : base(driver) { }

        public IWebElement EnableButton => Driver.FindElement(By.Id("enableAfter"));
        public IWebElement ChangeColorButton => Driver.FindElement(By.XPath("//*[@class='mt-4 text-danger btn btn-primary']"));
        public IWebElement VisibleButton => Driver.FindElement(By.Id("visibleAfter"));

        
    }
}
