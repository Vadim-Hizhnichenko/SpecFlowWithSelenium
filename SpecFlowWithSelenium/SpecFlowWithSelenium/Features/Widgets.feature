Feature: Widgets
	

@Accordian
Scenario: FirstAccordian
	Given I have base url site
	When I go to url 'accordian'
	And We click to first accordian button
	And See the text of this accordian
	Then We closed browser

@Accordian
Scenario: SecondAccordian
	Given I have base url site
	When I go to url 'accordian'
	And We click to second accordian button
	And See the text of second accordian
	Then We closed browser

@Accordian
Scenario: ThirdAccordian
	Given I have base url site
	When I go to url 'accordian'
	And We click to third accordian button
	And See the text of last accordian
	Then We closed browser