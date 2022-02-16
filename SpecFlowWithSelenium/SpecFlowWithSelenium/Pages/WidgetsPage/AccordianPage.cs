using OpenQA.Selenium;

namespace SpecFlowWithSelenium.Pages.WidgetsPage
{
    public class AccordianPage : BasePage
    {
        public AccordianPage(IWebDriver driver) : base(driver) { }


        public IWebElement FirstAccordian => Driver.FindElement(By.XPath("//*[@id='section1Heading']"));
        public IWebElement SecondAccordian => Driver.FindElement(By.XPath("//*[@id='section2Heading']"));
        public IWebElement ThirdAccordian => Driver.FindElement(By.XPath("//*[@id='section3Heading']"));


        public IWebElement FirstAccordianResult => Driver.FindElement(By.XPath("//*[@id='section1Content']"));
        public IWebElement SecondAccordianResult => Driver.FindElement(By.XPath("//*[@id='section2Content']"));
        public IWebElement ThirdAccordianResult => Driver.FindElement(By.XPath("//*[@id='section3Content']"));
    }
}
