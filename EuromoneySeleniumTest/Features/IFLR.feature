Feature: IFLR

Scenario: Open IFLR from Euromoney site
	Given I am on the Legal Media page
	When I click VISIT IFLR link
	Then IFLR site is opened in new tab
	And IFLR home page has correct title

Scenario: Choose package page
	Given I am on the IFLR main page
	When I click Subscribe button
	Then Subscription page should be opened
	And there should be next personal plan Options
	| Option			 |
	| Personal package	 |
	| Group package		 |
	| Renew your package |

Scenario: Choose personal package
	Given I am on the IFLR Subscription page
	When I click select personal plan button
	Then Checkout page should be opened