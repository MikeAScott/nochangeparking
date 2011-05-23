package com.sqs.nochangeparking.fitfixtures;

import fit.Fixture;
import fitlibrary.DoFixture;
import fitlibrary.SetFixture;

import com.sqs.nochangeparking.core.CallCentre;
import com.sqs.nochangeparking.core.DriverCall;
import com.sqs.nochangeparking.core.PaymentsList;

public class PayForParkingFixture extends DoFixture{

	private PaymentsList todaysPayments;
	
	public PayForParkingFixture() {
		todaysPayments = new PaymentsList();
	}
	
	public Fixture setupPayments() {
		return new SetupPaymentsListFixture(todaysPayments);
	}
	
	public DriverCall newCallFromDriver(String name) {
		return CallCentre.getInstance().newCallFromDriver(name);
	}
	
	public Fixture todaysPayments() {
		return new SetFixture(todaysPayments);
	}
	
}
