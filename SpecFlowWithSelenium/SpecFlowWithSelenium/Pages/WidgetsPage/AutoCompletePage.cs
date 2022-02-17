using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Pages.WidgetsPage
{
    public class AutoCompletePage : BasePage
    {
        public AutoCompletePage(IWebDriver driver) : base(driver) { }

        public IWebElement MyltipleColorInput => Driver.FindElement(By.XPath("//*[@id='autoCompleteMultipleInput']"));
        public IWebElement SinglColorInput => Driver.FindElement(By.XPath("//*[@id='autoCompleteSingleInput']"));

        public IWebElement ColorResult => Driver.FindElement(By.XPath("//*[@class='css-12jo7m5 auto-complete__multi-value__label']"));
        public IWebElement SinglColorResult => Driver.FindElement(By.XPath("//*[@class='auto-complete__single-value css-1uccc91-singleValue']"));

        
        public void SendColor(string colorName, IWebElement element)
        {
            var action = new Actions(Driver);
            element.SendKeys(colorName);
            action.MoveToElement(element).KeyDown(Keys.Enter).Perform();
        }
    }
}
