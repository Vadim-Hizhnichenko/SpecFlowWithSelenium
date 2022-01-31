using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Pages
{
    public class RadioButtonPage : BasePage
    {
        public RadioButtonPage(IWebDriver driver) : base(driver) { }

        public IWebElement ImpressiveRadioButton => Driver.FindElement(By.XPath("//*[@for='impressiveRadio']"));
        public IWebElement YesRadioButton => Driver.FindElement(By.XPath("//*[@for='yesRadio']"));

        public IWebElement TextSuccess => Driver.FindElement(By.XPath("//*[@class='text-success']"));
    }
}
