Feature: SpecFlow Evaluation
	In order to be appointed this contract
	As a candidate
	I want to demonstrate that I can write tests in SpecFlow (Gherkin).

Scenario Outline: The user can see a specific ingredient in the ingredients detail card
	Given the user can see the ingredients tab
	And the user clicks on the ingredients tab
	Then the user can see the ingredients list
	And the user can see 'Ingredient' in the ingredients list items
	And the user clicks on the 'Ingredient' item from the ingredients list 
	Then the user can see 'ingredient' in the ingredients detail card
	Examples: 
	| Ingredient |
	| cinnamon   |
	| apples     |
