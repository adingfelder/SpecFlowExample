Feature: ViewingDetail
	In order to view the detail
	As a customer
	I want to be able to view the item description

@mytag
Scenario: Item details can be displayed
	Given I am on the store page 
	When I click an item
	Then I should see item details 
