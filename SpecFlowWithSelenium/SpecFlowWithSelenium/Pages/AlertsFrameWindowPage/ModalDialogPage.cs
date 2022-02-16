using OpenQA.Selenium;

namespace SpecFlowWithSelenium.Pages.AlertsFrameWindowPage
{
    public class ModalDialogPage : BasePage
    {
        public ModalDialogPage(IWebDriver driver) : base(driver) { }

        public IWebElement SmallModalButton => Driver.FindElement(By.XPath("//*[@id='showSmallModal']"));
        public IWebElement LargeModalButton => Driver.FindElement(By.XPath("//*[@id='showLargeModal']"));


        public IWebElement SmallModalResult => Driver.FindElement(By.XPath("//*[@id='example-modal-sizes-title-sm']"));
        public IWebElement LargeModalResult => Driver.FindElement(By.XPath("//*[@id='example-modal-sizes-title-lg']"));

        

    }
}
