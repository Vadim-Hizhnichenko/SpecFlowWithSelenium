using NUnit.Framework;
using SpecFlowWithSelenium.Drivers;
using SpecFlowWithSelenium.Pages.AlertsFrameWindowPage;
using TechTalk.SpecFlow;

namespace SpecFlowWithSelenium.Steps
{
    [Binding]
    public sealed class AlertsFrameWindowsStep
    {
        private readonly BrowserWindowsPage _browserWindows;
        private readonly AlertsPage _alertsPage;
        private readonly ModalDialogPage _modalDialogPage;
        private readonly Driver _driver;

        public AlertsFrameWindowsStep(Driver driver)
        {
            _driver = driver;
            _browserWindows = new BrowserWindowsPage(driver.Current);
            _modalDialogPage = new ModalDialogPage(driver.Current);
            _alertsPage = new AlertsPage(driver.Current);
        }

        #region Browser Method Test
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
            //var x = _browserWindows.NewWindowMessage.Text;
        }
        #endregion

        #region Alerts Method Test
        [When(@"Click Alert Button")]
        public void WhenClickAlertButton()
        {
            _alertsPage.ClickAllertButton();
        }

        [When(@"Click Alert Button with timer")]
        public void WhenClickAlertButtonWithTimer()
        {
            _alertsPage.ClickAlertButtonWithTimer();
        }

        [When(@"Click Aleert confirm button")]
        public void WhenClickAleertConfirmButton()
        {
            _alertsPage.ClickConfirmButton();
        }

        [When(@"See confirm result '(.*)'")]
        public void WhenSeeConfirmResult(string result)
        {
            Assert.AreEqual(result, _alertsPage.ConfirmAlertResult.Text);
        }

        [When(@"Click promt button with data '(.*)'")]
        public void WhenClickPromtButtonWithData(string data)
        {
            _alertsPage.ClickPromtButton(data);
        }

        [When(@"See promt result '(.*)'")]
        public void WhenSeePromtResult(string result)
        {
            Assert.IsTrue(_alertsPage.PromtAlertResult.Displayed);
        }
        #endregion

        #region Modal Dialog Method Test

        [When(@"I click to small modal button")]
        public void WhenIClickToSmallModalButton()
        {
            _modalDialogPage.ClickElement(_modalDialogPage.SmallModalButton);
        }

        [When(@"See modal window text")]
        public void WhenSeeModalWindowText()
        {
            Assert.IsTrue(_modalDialogPage.SmallModalResult.Displayed);
        }

        [When(@"I click to large modal button")]
        public void WhenIClickToLargeModalButton()
        {
            _modalDialogPage.ClickElement(_modalDialogPage.LargeModalButton);
        }

        [When(@"See modal window large text")]
        public void WhenSeeModalWindowLargeText()
        {
            Assert.IsTrue(_modalDialogPage.LargeModalResult.Displayed);
        }


        #endregion
    }
}
