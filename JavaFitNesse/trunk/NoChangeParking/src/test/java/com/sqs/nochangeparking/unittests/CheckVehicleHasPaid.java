package com.sqs.nochangeparking.unittests;

import com.sqs.nochangeparking.core.PaymentsList;

import junit.framework.TestCase;

public class CheckVehicleHasPaid extends TestCase{

	private PaymentsList theList;
	
	
	protected void setUp() throws Exception {
		super.setUp();
		theList = new PaymentsList();
	}
	public void testVehicleCar1HasPaid() {
		theList.add("Car1");
		assertTrue(theList.hasPaid("Car1"));
	}
	
	public void testVehicleCarXHasNotPaid() {
		assertFalse( theList.hasPaid("CarX"));
	}
}