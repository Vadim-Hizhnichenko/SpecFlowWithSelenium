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

@AutoComplete
Scenario: SendMultipleColors
	Given I have base url site
	When I go to url 'auto-complete'
	And We send color 'Red'
	And See the color 'Red' in the input field
	Then We closed browser

@AutoComplete
Scenario: SendSinglColors
	Given I have base url site
	When I go to url 'auto-complete'
	And We send singl color 'Black'
	And See the color 'Black' 
	Then We closed browser

@DatePicker
Scenario: SelectDate
	Given I have base url site
	When I go to url 'date-picker'
	And Select date '2/17/2022'
	And See this date 
	Then We closed browser
	
@DatePicker
Scenario: SelectDateAndTime
	Given I have base url site
	When I go to url 'date-picker'
	And Select date with time 'June 17, 2021 4:03 PM'
	And See this date with time 
	Then We closed browser

@Slider
Scenario: SliderRun
	Given I have base url site
	When I go to url 'slider'
	And Click and hold slider
	And See value in window