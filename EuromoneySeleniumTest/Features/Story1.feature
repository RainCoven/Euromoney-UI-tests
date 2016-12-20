Feature: SpecFlowFeature1
	As a user
	I want to click the Who we are -> Management team menu item
	So that we can see that the correct page is displayed


Scenario: Check Management Page
	Given I opened the home page
	And I open side menu
	When I click "Who we are" first level menu link
	Then Submenu will be opened
	And then I click "Management team" second level menu link
	Then "Management team" page should be opened
	And Page is dispayed correctly
	And images have an url
