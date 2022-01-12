Feature: ApplyForJob
	Filling in the fileds of a custom job application 

@applyForJob
Scenario: Apply for a job
	Given I am on the Zenitech webiste
	And I browse through the available jobs
	When I can't find a role that suits me
	Then I should be able to fill in a custom job application form