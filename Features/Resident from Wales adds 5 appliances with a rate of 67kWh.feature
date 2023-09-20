Feature: Resident from Wales adds 5 appliances with a rate of 67kWh
	

Scenario: Resident from Wales adds 5 appliances with a rate of 67kWh
	Given user opens url
	And user clicks on 'location' button
	And user Validates that modal has popped up
	And user clicks on 'wales' button
	And user scrolls down to Calculator
	And user clicks on Add an appliance and chooses 'heat pump (air source)'
	And user chooses '2' hours and '0' minutes
	And user chooses every day
	And user clicks on p/kwh and inputs '67'
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'broadband router'
	And user chooses '24' hours and '0' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'pc or desktop computer'
	And user chooses '9' hours and '0' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'light bulb - energy saving cfl'
	And user chooses '12' hours and '0' minutes
	And user clicks on 'add appliance to your list' button	
	And user clicks on Add an appliance and chooses 'kettle'
	And user chooses '0' hours and '42' minutes
	And user clicks on 'add appliance to your list' button
	And user scrolls to Appliance Table
	And user validates the most expensive appliance
	Then user validates the other appliances in the table
	Then user validates the other appliances in the table for "wales"