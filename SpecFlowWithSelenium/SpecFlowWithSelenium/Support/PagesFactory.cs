using OpenQA.Selenium;
using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowWithSelenium.Support
{
    public class PagesFactory
    {
        public PagesFactory()
        {
            Driver = new Driver().Current;
            TextBoxPage = new TextBoxPage(Driver);
            CheckBox = new CheckBox(Driver);
        }

        public IWebDriver Driver { get; }
        public TextBoxPage TextBoxPage { get; }
        public CheckBox CheckBox { get; }
    }
}
