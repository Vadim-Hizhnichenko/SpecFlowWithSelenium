using OpenQA.Selenium;
using SpecFlowWithSelenium.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Support
{
    public class BaseFactory
    {

        public BaseFactory()
        {
            Driver = new Driver();
            ElementsPagesFactory = new ElementsPagesFactory();
            FormsPagesFactory = new FormsPagesFactory();
        }

        public Driver Driver { get; }

        //public IWebDriver Driver { get; }
        public ElementsPagesFactory ElementsPagesFactory { get; }
        public FormsPagesFactory FormsPagesFactory { get; }
    }
}
