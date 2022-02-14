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
	Then We closed browser
	
@BrowserWindowsButtonMessage
Scenario: BrowserNewWindowMessage
	Given I have base url site
	When I go to url 'browser-windows'
	And Click to New Window Message button
	And See the text in message 
	Then We closed browser

@AleertButton
Scenario: AlertButton
	Given I have base url site
	When I go to url 'alerts'
	And Click Alert Button
	Then We closed browser


@AlertButtonWithTimer
Scenario: AlertButtonWithTimer
	Given I have base url site
	When I go to url 'alerts'
	And Click Alert Button with timer
	Then We closed browser

@AllertConfirmButton
Scenario: AlertConfirmButton
	Given I have base url site
	When I go to url 'alerts'
	And Click Aleert confirm button
	And See confirm result 'You selected Ok'
	Then We closed browser
	


@AllertPromtButton
Scenario: AlertPromtButton
	Given I have base url site
	When I go to url 'alerts'
	And Click promt button with data 'My Name'
	And See promt result 'You entered My Name'
	Then We closed browser