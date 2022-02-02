Feature: Elements
	Tests all element in this page


@TextBox
Scenario: TexBox
	Given I have base url site
	When I go to url 'text-box'
	And Fill the form and submit date next data 
	| Full Name | Email           | Current Address | Permanent Address |
	| Ivan      | email@gmail.com | current address | permanent adress  |
	# Data has be displeyed
	And I see our date  
	Then We closed browser

@CheckBox
Scenario: CheckBox
	Given I have base url site 
	When I go to url 'checkbox'
	And Use button chebox
	# Data has be displeyed
	And I see text in window
	Then We closed browser

@RadioButton
Scenario: RadioButtonYes
	Given I have base url site
	When I go to url 'radio-button'
	And use radio button Yes
	And We see selected text 'Yes'
	Then We closed browser


@RadioButton
Scenario: RadioButtonImpressive
	Given I have base url site
	When I go to url 'radio-button'
	And use radio button Impressive
	And We see selected this text 'Impressive'
	Then We closed browser


@WebTablesAddNewUser
Scenario: AddNewUser
	Given I have base url site
	When I go to url 'webtables'
	And I click button Add
	And I create new user
	| FirstName | LastName | Age | Email           | Salary | Departament |
	| Petro     | Ivanov   | 20  | email@email.com | 1000   | departament |
	And Search created user with name 'Petro'
	Then We closed browser
	
@Buttons
Scenario: Buttons
	Given I have base url site
	When I go to url 'buttons'
	And I click three buttons
	And I see three message
	Then We closed browser

@LinksNewTab
Scenario: LinkWillOpenNewTab
	Given I have base url site
	When I go to url 'links'
	And I click to link
	And New tab with site opened
	Then We closed browser

@DynamicLinkNewtab
Scenario: DynamicLinkOpenNewTab
	Given I have base url site
	When I go to url 'links'
	And I click to dynamic link
	And New tab with site opened
	Then We closed browser

@LinkCreated
Scenario: LinkCreated
	Given I have base url site
	When I go to url 'links'
	And I click Created link
	And See result text on disply
	Then We closed browser

@LinkNoContent
Scenario: LinkNoContent
	Given I have base url site
	When I go to url 'links'
	And I click No Content link
	And See result text on disply
	Then We closed browser

@LinkMoved
Scenario: LinkMoved
	Given I have base url site
	When I go to url 'links'
	And I click Moved link
	And See result text on disply
	Then We closed browser

@LinkBadRequest
Scenario: LinkBadRequest
	Given I have base url site
	When I go to url 'links'
	And I click Bad Request link
	And See result text on disply
	Then We closed browser


@LinkUnauthorized
Scenario: LinkUnauthorized
	Given I have base url site
	When I go to url 'links'
	And I click Unauthorized link
	And See result text on disply
	Then We closed browser

@LinkForbidden
Scenario: LinkForbidden
	Given I have base url site
	When I go to url 'links'
	And I click Forbidden link
	And See result text on disply
	Then We closed browser

@LinkNotFound
Scenario: LinkNotFound
	Given I have base url site
	When I go to url 'links'
	And I click NotFound link
	And See result text on disply
	Then We closed browser

@BrokenLink
Scenario: ValidLink
	Given I have base url site
	When I go to url 'broken'
	And I click valid link 
	And I redirected to home page
	Then We closed browser

@BrokenLink
Scenario: BrokenLink
	Given I have base url site
	When I go to url 'broken'
	And I click invalid link 
	And I was redirected to error page
	Then We closed browser

@DownloadFile
Scenario: DowloadFile
	Given I have base url site
	When I go to url 'upload-download'
	And Click button download file
	And I see this file to the download folder
	Then We closed browser

@UploadFile
Scenario: UploadFile
	Given I have base url site
	When I go to url 'upload-download'
	And I click upload button and select file to upload 'C:\Users\khyzhnychenko\Desktop\test.txt'
	And The path of the loaded file is visible 
	Then We closed browser


@DynamicProperty
Scenario: DynamicProperty
	Given I have base url site
	When I go to url 'dynamic-properties'
	And The buttons become enable and visible
	Then We closed browser


