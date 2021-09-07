Feature: Login
	Login to LoginTest application

@test
Scenario: Perform Login of LT Application site
	Given I lunch application
	And I enter the folowwing details
	    | Username | Password |
	    | Tester   | test     |
	When I clcik login button
	Then I should see WebOrders Text