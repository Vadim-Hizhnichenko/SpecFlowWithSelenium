Feature: Forms
	

@InputRequiredData
Scenario: InputRequiredData
	Given I have base url site
	When I go to url 'automation-practice-form'
	And Input required user data 
	| First Name | Last Name | Email           | Mobile     |
	| Alex      | Qwerty    | email@email.com | 1234567899 |
	And Select gender type 'Male'
	Then We closed browser

@InputRequiredDataWithSubject
Scenario: InputRequiredDataAndSubject
	Given I have base url site
	When I go to url 'automation-practice-form'
	And Input required user data and subject 
	| First Name | Last Name | Email           | Mobile     | Subjects     |
	| Alex       | Qwerty    | email@email.com | 1234567899 | some subject |
	And Select gender type 'Male'
	Then We closed browser


@SelectState
Scenario: SelectState
	Given I have base url site
	When I go to url 'automation-practice-form'
	And Select State 'NCR'
	And Selected State are displyaed
	Then We closed browser

@SelectCity
Scenario: SelectCity
	Given I have base url site
	When I go to url 'automation-practice-form'
	And Select State 'NCR'
	And Choose a city 'Delhi'
	And City was be displayed
	Then We closed browser


@DataOfBirth
Scenario: DataOfBirth
	Given I have base url site
	When I go to url 'automation-practice-form'
