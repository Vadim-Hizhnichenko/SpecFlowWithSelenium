using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages.AlertsFrameWindowPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
