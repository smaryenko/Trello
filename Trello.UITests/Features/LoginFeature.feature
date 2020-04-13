Feature: LoginFeature

@login
Scenario Outline: Login with invalid credentials
	Given Login page is loaded
	When <email> and <password> are entered and login button pressed
	Then User sees error message <error>

Examples: 
	| email                            | password | error                                       |
	| invalidmail1                     | password | There isn't an account for this username    |
	| invalidmail2@.com                | password | There isn't an account for this email       |
	| invalidmail3@gmail               | password | There isn't an account for this email       |
	| invalidmail4!#$%^&*()_@gmail.com | password | There isn't an account for this email       |
