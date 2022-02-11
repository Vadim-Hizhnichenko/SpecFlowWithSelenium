using NUnit.Framework;
using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages;
using SpecFlowWithSelenium.Pages.AlertsFrameWindowPage;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public sealed class AlertsFrameWindowsStep
    {
        private readonly BrowserWindows _browserWindows;
        private readonly Driver _driver;

        public AlertsFrameWindowsStep(Driver driver)
        {
            _driver = driver;
            _browserWindows = new BrowserWindows(driver.Current);
        }

        [When(@"Click button New Tab")]
        public void WhenClickButtonNewTab()
        {
            _browserWindows.ClickElement(_browserWindows.NewTabButton);
        }


        [When(@"Click button New Window")]
        public void WhenClickButtonNewWindow()
        {
            _browserWindows.ClickElement(_browserWindows.NewWindowButton);
        }

        [When(@"We switched to new window")]
        public void WhenWeSwitchedToNewWindow()
        {
            _browserWindows.SwitchToWindow();
        }

        [When(@"We see title a new window")]
        public void WhenWeSeeTitleANewWindow()
        {
            Assert.IsTrue(_browserWindows.NewWindowTitle.Displayed);
        }

        [When(@"Click to New Window Message button")]
        public void WhenClickToNewWindowMessageButton()
        {
            _browserWindows.ClickElement(_browserWindows.NewWindowMessageButton);

        }

        [When(@"See the text in message")]
        public void WhenSeeTheTextInMessage()
        {
            
            _driver.Current.SwitchTo().NewWindow(0);
            var x = _browserWindows.NewWindowMessage.Text;
        }







    }
}
