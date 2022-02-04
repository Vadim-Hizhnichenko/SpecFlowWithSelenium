using OpenQA.Selenium;
using SpecFlowWithSelenium.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Support
{
    public  class BaseFactory
    {
        public BaseFactory()
        {
            Driver = new Driver().Current;
        }

        public IWebDriver Driver { get; }
    }
}
