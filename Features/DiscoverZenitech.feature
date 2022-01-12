Feature: DiscoverZenitech
	Simple feature to visit Zenitech's page

@discoverZenitech
Scenario: Who We Are section
	Given I want to know more about Zenitech
	When I visit their webiste
	Then I should see a Who We Are section