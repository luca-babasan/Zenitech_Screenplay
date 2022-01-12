Feature: FindAvailableJobs
	Simple script to visit the available jobs page and list the ones from Cluj-Napoca

@FindAvailableJobs
Scenario: Find available jobs
	Given I want to see the available jobs on the Zenitech website
	When I visit the Join Us section of the website
	Then I should be able to see the available jobs from Cluj-Napoca