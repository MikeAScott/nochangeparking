package com.sqs.nochangeparking.fitfixtures;

import com.sqs.nochangeparking.core.CallCentre;
import com.sqs.nochangeparking.core.DriverCall;

import fitlibrary.SetUpFixture;

public class SetupDefaultsFixture extends SetUpFixture {
	
	private CallCentre callCentre;
	
	public SetupDefaultsFixture( CallCentre callCentre){
		this.callCentre = callCentre;
	}
	
	public void driverDefaultVehicleDefaultCreditCard( String driver, String vehicle, String creditCard ) {
		DriverCall call = callCentre.newCallFromDriver(driver);
		call.registerVehicle(vehicle);
		call.registerCard(creditCard);
		return;
	}

}