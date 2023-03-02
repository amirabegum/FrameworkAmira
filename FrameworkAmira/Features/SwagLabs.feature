Feature: SwagLabs

Scenario: Verify the standard User can login successfully
	Given I am on the SwagLabs Page 
	When I enter the username "standard_user"
	And I enter the password 
	And I click the Login button
	Then I have successfully logged in 

Scenario: Verify an item can be added to the cart
	Given I am logged into SwagLabs
	When I click the Add To Cart button for a backpack
	And I click on the Cart button 
	Then the backpack is added to the cart

Scenario: Verify an item can be removed from the cart
	Given I am logged into SwagLabs
	When I click the Add To Cart button for a backpack
	And I click on the Cart button 
	And the backpack is added to the cart
	And I click on the Remove button 
	Then the backpack will be removed from the cart 

Scenario: Verify successful checkout 
	Given I am logged into SwagLabs
	When I click the Add To Cart button for a backpack
	And I click on the Cart button 
	And I click on Checkout 
	And I enter the first name "Amira"
	And I enter the last name "Begum"
	And I enter the post code "PR76TE"
	And I click Continue 
	And I click Finish
	Then the order has been successfully completed
	
Scenario: Verify user can filter items from highest to lowest price
	Given I am logged into SwagLabs
	When I click on the Filter icon 
	And I select lowest to highest
	Then the products have been filtered 

Scenario: Verify locked user cannot login
	Given I am on the SwagLabs Page 
	When I enter the username "locked_out_user"
	And I enter the password 
	And I click the Login button
	Then the user cannot login

Scenario: Failed test for reporting purposes 
	Given I am on the SwagLabs Page 
	When I enter the username "user_101*"
	And I enter the password 
	And I click the Login button
	Then I have successfully logged in 
