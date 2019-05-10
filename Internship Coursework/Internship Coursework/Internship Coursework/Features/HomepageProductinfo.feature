Feature: HomepageProductinfo
	As a registered user
	I want to be able to login
	I want to view products on my homepage

@mytag
Scenario: Homepage Product Information
	Given I navigate to giftrete website
	When I click on login
	And I enter my email address
	And I enter my password
	And I click sign in
	And I click the hometab
	And I click free items
	And I click wishlist
	And I click community
	Then I have the information about the products
