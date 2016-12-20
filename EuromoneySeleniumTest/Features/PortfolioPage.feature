Feature: SpecFlowFeature2
	As a user
	I want to see International Financial Law Review on Our Portfolio -> Legal Media Page
	So that I can reach it and see subscription info



Scenario: Check Our Portfolio Page existance
	Given I opened the home page
	When I click Portholio button
	Then I should see Portfolio page

Scenario: Open Legal Media page
	Given I am on the Our portfolio page
	When I click on Legal media link
	Then I should see Legal media page
	And page has "VISIT IFLR" link