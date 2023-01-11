Feature: Amazon 

Scenario: Sign in to Account 
	Given I am logged into my account
	When I search for "Books" in the search bar
	Then the books results will be displayed 
	
Scenario: Filter for books using the main menu 
	Given I am on the Amazon Homepage 
	When I select "Books" from the main menu 
	Then the books results will be displayed