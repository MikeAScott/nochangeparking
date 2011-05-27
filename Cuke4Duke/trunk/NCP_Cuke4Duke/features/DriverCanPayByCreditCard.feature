Feature: Driver Can Pay By Credit Card
	In order to avoid having to use coins in a parking meter
	As a driver
	I want to be able pay for my parking by credit card

Business Rules:
	To pay for parking, a Driver must give their Vehicle Registration and Credit Card Number
	A vehicle is considered not paid for if it is not on the current payments list
	Once paid, the vehicle is logged on the Payments list

Background:
	Given The following payments list
	|Vehicle|
	|Car6|
	|Car7|

@driver
Scenario: Once paid, a vehicle appears on the Payments list
	
	When We get a new call from driver 'Dave'
	And He pays to park 'Green Polo' with a valid credit card
	
	Then the payment should be accepted
	And the payments list should show
	|Vehicle|
	|Car6|
	|Car7|
	|Red Polo|

@driver
Scenario: Reject duplicate payment for same vehicle, but leave existing payment on the payments list

	When We get a new call from driver 'AnyDriver'
	And He pays to park 'Car7' with a valid credit card
	Then the payment should be rejected
	And the payments list should show
	|Vehicle|
	|Car6|
	|Car7|

