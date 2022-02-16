using OpenQA.Selenium;
using System.Linq;

namespace SpecFlowWithSelenium.Pages.AlertsFrameWindowPage
{
    public class BrowserWindowsPage : BasePage
    {
        public BrowserWindowsPage(IWebDriver driver) : base(driver) { }


        public IWebElement NewTabButton => Driver.FindElement(By.XPath("//*[@id='tabButton']"));
        public IWebElement NewWindowButton => Driver.FindElement(By.XPath("//*[@id='windowButton']"));
        public IWebElement NewWindowMessageButton => Driver.FindElement(By.XPath("//*[@id='messageWindowButton']"));


        public IWebElement NewWindowTitle => Driver.FindElement(By.XPath("//*[@id='sampleHeading']"));
        public IWebElement NewWindowMessage => Driver.FindElement(By.TagName("body"));
        public void SwitchToWindow()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
        }
        
    }
}
