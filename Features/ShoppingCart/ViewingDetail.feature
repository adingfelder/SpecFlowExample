Feature: ViewingDetail
	In order to view the detail
	As a customer
	I want to be able to view the item description

@mytag
Scenario: Item details displayed
	Given Navigate to the homepage 
	When I click an the targeted item
	Then I should see the targeted Item
