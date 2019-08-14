Feature: SpecFlowShoppingCartFeature
	In order to validate our online store
	As a shopper
	I want to be able to log into the store and buy stuff

@mytag
Scenario: Successfully Log In
	Given I am on the store page 
    When I click the login button
    Then I should see my name

@mytag
Scenario: Item details can be displayed
	Given I am on the store page 
    When I click an item
    Then I should see item details

