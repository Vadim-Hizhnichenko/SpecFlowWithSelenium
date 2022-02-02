using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlowWithSelenium.Extensions
{
    // if my class with driver(implicit wait) dont work, use this extension for find element 
    public static class WebElementExtension
    {
        public static IWebElement FindElementWithTimeOut(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }

}
