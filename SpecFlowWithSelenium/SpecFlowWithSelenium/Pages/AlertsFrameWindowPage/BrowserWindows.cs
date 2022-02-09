using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecFlowWithSelenium.Pages.AlertsFrameWindowPage
{
    public class BrowserWindows : BasePage
    {
        public BrowserWindows(IWebDriver driver) : base(driver) { }


        public IWebElement NewTabButton => Driver.FindElement(By.XPath("//*[@id='tabButton']"));
        public IWebElement NewWindowButton => Driver.FindElement(By.XPath("//*[@id='windowButton']"));
        public IWebElement NewWindowMessageButton => Driver.FindElement(By.XPath("//*[@id='messageWindowButton']"));

        public void SwitchWindow()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
        }

        
    }
}
