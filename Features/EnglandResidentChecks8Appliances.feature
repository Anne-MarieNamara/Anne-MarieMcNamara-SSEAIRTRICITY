Feature: Resident from England checks 8 appliances with a rate of 34kWh
	Resident in England checks 8 appliances and sees the results table
	with daily, weekly, montly and yearly cost

@mytag
Scenario: Resident from England checks 8 appliances with a rate of 34kWh
	Given user opens url
	And user clicks on 'location' button
	And user Validates that modal has popped up
	And user clicks on 'england' button
	And user scrolls down to Calculator
	And user clicks on Add an appliance and chooses 'electric blanket'
	And user chooses '8' hours and '0' minutes
	And user chooses every day
	And user clicks on p/kwh and inputs '34'
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'immersion heater'
	And user chooses '1' hours and '0' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'fan heater'
	And user chooses '4' hours and '30' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'broadband router'
	And user chooses '24' hours and '0' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'pc or desktop computer'
	And user chooses '9' hours and '15' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'phone or tablet charger'
	And user chooses '0' hours and '45' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'light bulb - energy saving led'
	And user chooses '12' hours and '0' minutes
	And user clicks on 'add appliance to your list' button
	And user clicks on Add an appliance and chooses 'grill or hob(electric)'
	And user chooses '1' hours and '10' minutes
	And user clicks on 'add appliance to your list' button
	And user scrolls to Appliance Table
	And user validates the most expensive appliance
	Then user validates the other appliances in the table








	