Feature: calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers table
	Given I have entered <number1> into the calculator
	And I have entered <number2> into the calculator
	When I press add
	Then the result should be <result> on the screen
	
Scenarios:
	| number1 | number2 | result |
	| 70      | 50      | 120    |
	| 100     | 50      | 150    |
	| 20      | -50     | -30    |
	| 10      | 50      | 60     |

Scenario Outline: Subtract two numbers
	Given I have entered <number1> into the calculator
	And I have entered <number2> into the calculator
	When I press subtract
	Then the result should be <result> on the screen

Scenarios:
	| number1 | number2 | result |
	| 70      | 50      | 20     |
	| 100     | 50      | 50     |
	| 20      | 50      | -30    |
	| 10      | 50      | -40    |

Scenario Outline: multiply two numbers
	Given I have entered <number1> into the calculator
	And I have entered <number2> into the calculator
	When I press multiply
	Then the result should be <result> on the screen

Scenarios: 
	| number1 | number2 | result |
	| 100     | 2       | 200    |
	| 4       | 2       | 8      |
	| 100     | -2      | -200   |
	| 5       | 0       | 0      |

Scenario: Divide a number by a number
	Given I have entered 120 into the calculator
	And I have entered 30 into the calculator
	When I press divide
	Then the result should be 4 on the screen

Scenario Outline: Divide a number tests
	Given I have entered <number1> into the calculator
	And I have entered <number2> into the calculator
	When I press divide
	Then the result should be <result> on the screen

Scenarios: 
	| number1 | number2 | result        |
	| 100     | 2       | 50            |
	| 4       | 2       | 2             |
	| 100     | -2      | -50           |
