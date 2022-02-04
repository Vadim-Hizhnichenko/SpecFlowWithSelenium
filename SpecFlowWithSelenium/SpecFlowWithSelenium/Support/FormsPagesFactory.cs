using OpenQA.Selenium;
using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages;
using SpecFlowWithSelenium.Pages.FormsPage;

namespace SpecFlowWithSelenium.Support
{
    public class FormsPagesFactory : BaseFactory
    {
        public FormsPagesFactory() 
        {
            PracticeFormPage = new PracticeFormPage(Driver);
        }

        //public IWebDriver Driver { get; }
       
        public PracticeFormPage PracticeFormPage { get; }
    }
}
