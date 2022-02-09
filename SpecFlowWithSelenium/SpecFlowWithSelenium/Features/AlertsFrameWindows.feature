Feature: AlertsFrameWindows
	


@BrowserWindowsButton
Scenario: BrowserWindowNewtab
	Given I have base url site
	When I go to url 'browser-windows'
	And Click button New Tab
	And We switched to new tab