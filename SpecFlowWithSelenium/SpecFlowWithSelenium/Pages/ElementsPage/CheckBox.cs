using OpenQA.Selenium;

namespace SpecFlowWithSelenium.Pages
{
    public class CheckBox : BasePage
    {
        public CheckBox(IWebDriver driver) : base(driver) { }


        public IWebElement SelectAllFileElement => Driver.FindElement(By.ClassName("rct-checkbox"));

        public IWebElement TrianglButtonNonColapsed => Driver.FindElement(By.ClassName("rct-node rct-node-parent rct-node-expanded"));

        public IWebElement TrianglButtonExpanded => Driver.FindElement(By.ClassName("rct-collapse rct-collapse-btn"));

        public IWebElement SpanTextElement => Driver.FindElement(By.XPath("//span[text()='You have selected :']"));
    }
}
