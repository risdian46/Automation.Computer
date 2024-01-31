Feature: ComputerTest


Scenario: User is able to Add a new computer
	Given User open the Computer website successfully
	And User create new Computer by filling the details 
	| Key          | Value            |
	| ComputerName | Risdian Computer |
	| Introduced   | 2019-01-01       |
	| Discontinued | 2020-10-10       |
	| Company      | IBM              |
	Then alert message "Done ! Computer Risdian Computer has been created" successfully created is appears
