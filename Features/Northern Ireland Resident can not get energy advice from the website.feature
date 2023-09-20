Feature: Northern Ireland Resident can not get energy advice from the website
	

Scenario: Northern Ireland Resident can not get energy advice from the website
	Given user opens url
	And user clicks on 'location' button
	And user Validates that modal has popped up
	And user clicks on 'northern ireland' button
	Then user validates text