Feature: AlertsFrameWindows
	


@BrowserWindowsButton
Scenario: BrowserWindowNewtab
	Given I have base url site
	When I go to url 'browser-windows'
	And Click button New Tab
	And We switched to new window
	And We see title a new window
	Then We closed browser

@BrowserWindowsButton
Scenario: BrowserNewWindow
	Given I have base url site
	When I go to url 'browser-windows'
	And Click button New Window
	And We switched to new window 
	And We see title a new window
	
@BrowserWindowsButtonMessage
Scenario: BrowserNewWindowMessage
	Given I have base url site
	When I go to url 'browser-windows'
	And Click to New Window Message button
	And See the text in message 
