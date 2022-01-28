Feature: Elements
	Tests all element in this page


@TextBox
Scenario: TexBox
	Given I am navigate to website
	When I go to the panel I need 'item-0'
	And Fill the form and submit date
	And I see our date
	Then We closed browser

@CheckBox
Scenario: CheckBox
	Given I am navigate to website 
	When I go to the panel I need 'item-1'
	And Use button chebox
	And I see text in window
	Then We closed browser