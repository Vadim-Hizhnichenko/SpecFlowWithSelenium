using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SpecFlowWithSelenium.Pages.AlertsFrameWindowPage
{
    public class AlertsPage : BasePage
    {
        public AlertsPage(IWebDriver driver) : base(driver) { }

        public IWebElement AlertButton => Driver.FindElement(By.XPath("//*[@id='alertButton']"));
        public IWebElement TimerAlertButton => Driver.FindElement(By.XPath("//*[@id='timerAlertButton']"));
        public IWebElement ConfirmAlertButton => Driver.FindElement(By.XPath("//*[@id='confirmButton']"));
        public IWebElement PromtAlertButton => Driver.FindElement(By.XPath("//*[@id='promtButton']"));

        public IWebElement ConfirmAlertResult => Driver.FindElement(By.XPath("//*[@id='confirmResult']"));
        public IWebElement PromtAlertResult => Driver.FindElement(By.XPath("//*[@id='promptResult']"));


        public void ClickAllertButton()
        {
            ClickElement(AlertButton);
            Driver.SwitchTo().Alert().Accept();
        }

        public void ClickConfirmButton()
        {
            ClickElement(ConfirmAlertButton);
            Driver.SwitchTo().Alert().Accept();
        }

        public void ClickAlertButtonWithTimer()
        {
            ClickElement(TimerAlertButton);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(6));
            wait.Until(ExpectedConditions.AlertIsPresent());
            Driver.SwitchTo().Alert().Accept();
        }

        public void ClickPromtButton(string data)
        {
            ClickElement(PromtAlertButton);
            Driver.SwitchTo().Alert().SendKeys(data);
            Driver.SwitchTo().Alert().Accept();
        }

    }
}
