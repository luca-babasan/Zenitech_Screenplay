Feature: FindAvailableJobs
	Simple script to visit the available QA jobs page and list the ones from Cluj-Napoca

@FindAvailableJobs
Scenario: Find available QA jobs
	Given I want to see the available QA jobs on the Zenitech website
	When I visit the Careers tab of the website
	Then I should be able to see the available jobs from Cluj-Napoca