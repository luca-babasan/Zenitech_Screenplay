Feature: FindKinga
	Simple feature to find Kinga

@findKinga
Scenario: Look for Kinga Daradics
	Given I want to find some info about Kinga Daradics
	When I browse the Who We Are section of Zenitech's website
	Then I should be able to find an article about Kinga
	And The news article should contain a quote from Kinga