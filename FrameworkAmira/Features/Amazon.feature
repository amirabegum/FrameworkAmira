Feature: Amazon 

Background: 
	Given I am on the Amazon Homepage 

Scenario: Sign in to Account 
	Given I am logged into my account
	When I search for "Books" in the search bar
	Then the books results will be displayed 
	
Scenario: Filter for books using the main menu 
	When I select "Books" from the main menu 
	Then the books results will be displayed

Scenario: Search can be filtered by department
	When the search filter is set to "Books" 
	And I submit the search bar 
	Then the books results will be displayed

Scenario: Generic searches can be filtered by department 
	Given the search filter is set to "All Departments"
	When I search for "1984" in the search bar
	Then "Books" will be present in the Department filters 

Scenario Outline: Filter by Author 
	When I search for "<title>" in the search bar
	And I select "<author>" from the Author filter 
	Then the number of search results will be displayed 
	And search results will display that they are for the filter "<author>"

	Examples: 
	| title              | author        |
	| 1984               | George Orwell |
	| Brave New World    | Aldous Huxley |

