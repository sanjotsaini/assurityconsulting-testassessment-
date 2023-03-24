Feature: SandboxCategories

A short summary of the feature

@HappyPath
Scenario Outline: Verify the name from categories API	
	When I send the request to get categories with "<id>" and "<catalogue>" to Sand box
	Then Verify the response status is succesfull
	And The response body contains following fields 
	| Name           | CanRelist | PromotionName | PromotionDescription      |
	| Carbon credits | True      | Gallery       | Good position in category |
	Examples: 
	| id   | catalogue |
	| 6327 | true      |

@NegativeTest
Scenario Outline: Verify the Categories API with incorect ID  	
	When I send the request to get categories with "<id>" and "<catalogue>" to Sand box
	Then Verify the response status is Bad Request
	And The error message is "Category 231 was not found"	
	Examples: 
	| id  | catalogue |
	| 231 | true      |