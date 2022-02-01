using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Pages
{
    public class BrokenLinkPage : BasePage
    {
        public BrokenLinkPage(IWebDriver driver) : base(driver) { }

        public IWebElement ValidLink => Driver.FindElement(By.LinkText("Click Here for Valid Link"));
        public IWebElement BrokenLink => Driver.FindElement(By.LinkText("Click Here for Broken Link"));


        public IWebElement AnwerBrokenLink => Driver.FindElement(By.LinkText("Elemental Selenium"));
    }
}
