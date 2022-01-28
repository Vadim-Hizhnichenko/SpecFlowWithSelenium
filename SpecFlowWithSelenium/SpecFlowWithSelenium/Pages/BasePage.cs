using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

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
