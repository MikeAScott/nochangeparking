Feature: Application Info
	In order to know what application we are running
	As a application user
	I want the application to tell me information about its configuration

@info
Scenario: Application Info
	When I ask for the application name
	Then the application name should be "No Change Parking" 
	