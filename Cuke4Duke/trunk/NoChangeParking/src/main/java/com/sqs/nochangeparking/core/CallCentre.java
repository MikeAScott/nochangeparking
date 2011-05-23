package com.sqs.nochangeparking.core;

public class CallCentre {

	private static CallCentre _instance;
	private PaymentsList _todaysPayments; 
	private DriversList _driverList; 

	private CallCentre() {
	}
	
	public static CallCentre getInstance() {
			if(_instance == null)
				_instance = new CallCentre();
			return _instance;
	}

	public PaymentsList getTodaysPayments() {
		if (_todaysPayments == null)
			_todaysPayments =  new PaymentsList(); ;
		return _todaysPayments;
	}

	public DriversList getDrivers() {
		if (_driverList == null)
			_driverList = new DriversList(); ;
		return _driverList;
	}

	public DriverCall newCallFromDriver(String name) {
		Driver driver = getDrivers().findDriver(name);
		if (driver == null)
			driver = new Driver(name);
		return new DriverCall(this, driver);
	}

	public boolean vehicleHasPaid( String vehicle ) {
		return _todaysPayments.hasPaid(vehicle);
	}

	public boolean vehicleHasNotPaid( String vehicle ) {
		return !vehicleHasPaid(vehicle);
	}

}
