Feature: SpecFlowFeature1
	As a user
	I want to click the Who we are -> Management team menu item
	So that we can see that the correct page is displayed


Scenario: Check Management Page existance
	Given I opened the home page
	And I open side menu
	When I click "Who we are" first level menu link
	Then Submenu will be opened
	And then I click "Management team" second level menu link
	Then "Management team" page should be opened

Scenario: Validate Management Page UI
	Given I opened Management Page
	And the page title is "Management team | Who we are | Euromoney Institutional Investor PLC"
	And first image has an URL
	When I will open side menu
	Then menu will be visible
	And menu will have next links
	| link								|
	| Investor Relations				|
	| Careers at Euromoney				|
	| Corporate social responsibility	|
	| Our portfolio						|
	And footer will be visivle
	And LinkedIn icon will be presrsent
	And footer menu will have next links
	| Link			 |
	| Contact Us	 |
	| T&Cs			 |
	| Privacy Policy |
	| Cookie Policy  |