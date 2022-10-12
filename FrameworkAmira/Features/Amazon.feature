Feature: Amazon 

Scenario: Sign in to Account 
	Given I am logged into my account
	When I search for "Books" in the search bar
	Then the books results will be displayed 
	