Feature: Test
	Validate adding new contact information

@smoke
Scenario: Data Entry of a New Contact
	Given Log into the CRM application.
	And Navigate to the Contacts section.
	And Click on the ‘New Contact’ button.
	When Enter all mandatory fields with valid data
	And Save the new contact.
	Then The contact should create