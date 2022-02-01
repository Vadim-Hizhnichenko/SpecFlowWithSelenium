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
            RadioButtonPage = new RadioButtonPage(Driver);
            WebTablesPage = new WebTablesPage(Driver);
            ButtonsPage = new ButtonsPage(Driver);
            LinksPage = new LinksPage(Driver);
            BrokenLinkPage = new BrokenLinkPage(Driver);
            UploadAndDownloadPage = new UploadAndDownloadPage(Driver);
        }

        public IWebDriver Driver { get; }
        public TextBoxPage TextBoxPage { get; }
        public CheckBox CheckBox { get; }
        public RadioButtonPage RadioButtonPage { get; }
        public WebTablesPage WebTablesPage { get; }
        public ButtonsPage ButtonsPage { get; }
        public LinksPage LinksPage { get; }
        public BrokenLinkPage BrokenLinkPage { get; }
        public UploadAndDownloadPage UploadAndDownloadPage { get; }
    }
}
