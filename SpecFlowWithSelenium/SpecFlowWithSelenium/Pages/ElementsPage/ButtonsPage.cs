using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowWithSelenium.Pages
{
    public class ButtonsPage : BasePage
    {
        public ButtonsPage(IWebDriver driver) : base(driver) 
        {

        }

        public IWebElement ClickMeButton => Driver.FindElement(By.XPath("//*[@class='btn btn-primary'][text()='Click Me']"));
        public IWebElement RightClickMeButton => Driver.FindElement(By.Id("rightClickBtn"));
        public IWebElement DoubleClickMeButton => Driver.FindElement(By.Id("doubleClickBtn"));


        public IWebElement ClickMeMessage => Driver.FindElement(By.Id("dynamicClickMessage"));
        public IWebElement RightClickMeMessage => Driver.FindElement(By.Id("rightClickMessage"));
        public IWebElement DoubleClickMeMessage => Driver.FindElement(By.Id("doubleClickMessage"));



        public void DoRightClick()
        {
            var actions = new Actions(Driver);
            actions.ContextClick(RightClickMeButton).Perform();
        }

        public void DoDoubleClick()
        {
            var actions = new Actions(Driver);
            actions.DoubleClick(DoubleClickMeButton).Perform();
        }
    }
}
