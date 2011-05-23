package com.sqs.nochangeparking.core;

public class DriverCall {
	private CallCentre _callCentre;
	private Driver _driver;
	private String _vehicle;
	private String _creditCard;

	public DriverCall(CallCentre callCentre, Driver driver) {
		_callCentre = callCentre;
		_driver = driver;
		_vehicle = "";
		_creditCard = "";
	}

	public Driver getDriver() {
		return _driver;
	}

	public String getVehicle() {
		return _vehicle; 
	}

	public String getCreditCard() {
		return _creditCard; 
	}

	public String getDefaultVehicle() {
		return _driver.getDefaultVehicle();
	}

	public String getDefaultCreditCard() {
		return _driver.getDefaultCreditCard();
	}

	public boolean payForVehicleWithCreditCard(String vehicle, String creditCardNumber ) {
		if( _callCentre.getTodaysPayments().hasPaid(vehicle) )
			return false;
		_callCentre.getTodaysPayments().AddPayment(vehicle);
		return true;
	}

	public boolean registerVehicle( String vehicle ) {
		ensureDriverIsRegistered();
		return _driver.registerVehicle(vehicle);
	}

	private void ensureDriverIsRegistered() {
		if (!_callCentre.getDrivers().contains(_driver)){
			_callCentre.getDrivers().add(_driver);
		}
	}

	public boolean registerCard( String ccNo ) {
		ensureDriverIsRegistered();
		return _driver.registerCard(ccNo);
	}

}
