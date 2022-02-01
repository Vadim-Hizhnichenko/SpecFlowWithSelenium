Feature: Elements
	Tests all element in this page


@TextBox
Scenario: TexBox
	Given I am navigate to website
	When I go to the panel I need 'item-0'
	And Fill the form and submit date next data 
	| Full Name | Email           | Current Address | Permanent Address |
	| Ivan      | email@gmail.com | current address | permanent adress  |
	# Data has be displeyed
	And I see our date  
	Then We closed browser

@CheckBox
Scenario: CheckBox
	Given I am navigate to website 
	When I go to the panel I need 'item-1'
	And Use button chebox
	# Data has be displeyed
	And I see text in window
	Then We closed browser

@RadioButton
Scenario: RadioButtonYes
	Given I am navigate to website
	When I go to the panel I need 'item-2'
	And use radio button Yes
	And We see selected text 'Yes'
	Then We closed browser


@RadioButton
Scenario: RadioButtonImpressive
	Given I am navigate to website
	When I go to the panel I need 'item-2'
	And use radio button Impressive
	And We see selected this text 'Impressive'
	Then We closed browser


@WebTablesAddNewUser
Scenario: AddNewUser
	Given I am navigate to website
	When I go to the panel I need 'item-3'
	And I click button Add
	And I create new user
	| FirstName | LastName | Age | Email           | Salary | Departament |
	| Petro     | Ivanov   | 20  | email@email.com | 1000   | departament |
	And Search created user with name 'Petro'
	Then We closed browser
	
@Buttons
Scenario: Buttons
	Given I am navigate to website
	When I go to the panel I need 'item-4'
	And I click three buttons
	And I see three message
	Then We closed browser

@LinksNewTab
Scenario: LinkWillOpenNewTab
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click to link
	And New tab with site opened
	Then We closed browser

@DynamicLinkNewtab
Scenario: DynamicLinkOpenNewTab
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click to dynamic link
	And New tab with site opened
	Then We closed browser

@LinkCreated
Scenario: LinkCreated
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click Created link
	And See result text on disply
	Then We closed browser

@LinkNoContent
Scenario: LinkNoContent
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click No Content link
	And See result text on disply
	Then We closed browser

@LinkMoved
Scenario: LinkMoved
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click Moved link
	And See result text on disply
	Then We closed browser

@LinkBadRequest
Scenario: LinkBadRequest
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click Bad Request link
	And See result text on disply
	Then We closed browser


@LinkUnauthorized
Scenario: LinkUnauthorized
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click Unauthorized link
	And See result text on disply
	Then We closed browser

@LinkForbidden
Scenario: LinkForbidden
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click Forbidden link
	And See result text on disply
	Then We closed browser

@LinkNotFound
Scenario: LinkNotFound
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click NotFound link
	And See result text on disply
	Then We closed browser

@BrokenLink
Scenario: ValidLink
	Given I am navigate to website
	When I go to the panel I need 'item-6'
	And I click valid link 
	And I redirected to home page
	Then We closed browser

@BrokenLink
Scenario: BrokenLink
	Given I am navigate to website
	When I go to the panel I need 'item-6'
	And I click invalid link 
	And I was redirected to error page
	Then We closed browser

@UploadAndDownload
Scenario: DowloadFile
	Given I am navigate to website
	When I go to the panel I need 'item-7'
	And Click button download file
	And I have this file
	#Then We closed browser