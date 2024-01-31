Feature: JSAlertTest

A short summary of the feature

Scenario: User is able to interact with the alert box
	Given User open the JSAlert website successfully
	When User click button of Click for JS Alert
	And Click OK button
	Then alert message "You successfully clicked an alert" is appears

Scenario: User is able to click the OK button on the confirmation box
	Given User open the JSAlert website successfully
	When User click button of Click for JS Confirm
	And Click OK JS Confirm button
	Then alert message "You clicked: Ok" is appears

Scenario: User is able to click the Cancel button on the confirmation box
	Given User open the JSAlert website successfully
	When User click button of Click for JS Confirm
	And Click Cancel JS Confirm button
	Then alert message "You clicked: Cancel" is appears

Scenario: User is able to type keyboard characters into the alert box
	Given User open the JSAlert website successfully
	When User click button of Click for JS Prompt
	And User enter the "Test" text on the alert pop up message and click OK
	Then alert message "You entered: Test" is appears

Scenario: User is able to click the "Cancel" button on the alert box
	Given User open the JSAlert website successfully
	When User click button of Click for JS Prompt
	And User enter the "Test" text on the alert pop up message and click Cancel
	Then alert message "You entered: null" is appears

Scenario: User is able to type keyboard characters into the alert box with failed result
	Given User open the JSAlert website successfully
	When User click button of Click for JS Prompt
	And User enter the "Test" text on the alert pop up message and click OK
	Then alert message "You entered: test11" is appears