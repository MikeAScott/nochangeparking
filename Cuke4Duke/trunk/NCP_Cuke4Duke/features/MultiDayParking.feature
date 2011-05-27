Feature: Drivers can specify how many days parking they want to park for (up to 7 days).

	In order to avoid having to make several calls for long stays
	As a driver phone up and pay for multiple days parking
	I want to be told the sum of two numbers

Need to:
 * specify number of days when calling
 * reject if more than 7 days
 * calculate amount to pay

@multiday_parking
Scenario Outline: Calculate the rate for multiple days parking
	Given The daily parking rate is £6.00
	When The driver parks for <Duration> days
	Then The payment amount should be <Payment Amount>

	Examples:
		|Duration	|Payment Amount|
		|1			|£6.00		|
		|2			|£12.00		|
		|7			|£42.00		|


