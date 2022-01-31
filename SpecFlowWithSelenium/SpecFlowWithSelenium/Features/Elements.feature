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
Scenario: RadioButton
	Given I am navigate to website
	When I go to the panel I need 'item-2'
	And use radio button Yes
	And We see selected text 'Yes'
	Then We closed browser
	#And use radio button Impressive
	#And We see selected text 'Impressive'
	#Then We closed browser
	
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
Scenario: LinksWillOpenNewTabs
	Given I am navigate to website
	When I go to the panel I need 'item-5'
	And I click to link
	And New tab with site opened
	Then We closed browser

@LinksWithApiAnswer
Scenario: LinksWithApiAnswer
	Given I am navigate to website
	When I go to the panel I need 'item-5'