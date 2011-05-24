Feature: An Inspector Can Check A Vehicle
	In order to issue tickets for illegally parked cars.
	As a Parking Inspector
	I want to be able to check whether or not a given vehicle in the car park has paid

@inspector
Scenario: An Inspector can check that individual vehicles have paid
	Given The following payments list
	|Vehicle|
	|Car1|
	|Car2|

	Then 'Car1' should show as paid
	And 'Carx' should show as not paid

@inspector
Scenario: Given a different list inspected can check
	Given The following payments list
	|Vehicle|
	|Car3|

	Then 'Car1' should show as not paid
	And 'Car3' should show as paid


