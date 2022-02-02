using OpenQA.Selenium;

namespace SpecFlowWithSelenium.Pages
{
    public class LinksPage : BasePage
    {
        public LinksPage(IWebDriver driver) : base(driver) { }

        public IWebElement HomeLink => Driver.FindElement(By.Id("simpleLink"));
        public IWebElement HomeDynamicLink => Driver.FindElement(By.Id("dynamicLink"));

        public string Title => Driver.Title;

        #region Links Region
        public IWebElement CreatedLink => Driver.FindElement(By.Id("created"));

        public IWebElement NoContentLink => Driver.FindElement(By.Id("no-content"));

        public IWebElement MovedLink => Driver.FindElement(By.Id("moved"));

        public IWebElement BadRequestLink => Driver.FindElement(By.Id("bad-request"));

        public IWebElement UnauthorizedLink => Driver.FindElement(By.Id("unauthorized"));

        public IWebElement ForbiddenLink => Driver.FindElement(By.Id("forbidden"));

        public IWebElement NotFountLink => Driver.FindElement(By.Id("invalid-url"));

        public IWebElement LinkResponse => Driver.FindElement(By.Id("linkResponse"));
        #endregion

        #region Message 



        #endregion

    }
}
