package com.sqs.nochangeparking.unittests;

import com.sqs.nochangeparking.core.Payment;

import junit.framework.TestCase;

public class CheckPayment extends TestCase {
	
	public void testCanCreate() {
		assertNotNull(new Payment("veh2"));
	}
	
	public void testCanGetVehicle() {
		Payment payment = new Payment("veh3");
		assertEquals("veh3", payment.getVehicle());
	}
	
	public void testPaymentsWithSameVehicleAreEqual(){
		Payment payment4 = new Payment("veh4");
		assertTrue(payment4.equals(new Payment("veh4")));
	}
	
	public void testPaymentsWithSameStringValueVehicleAreEqual(){
		Payment payment4 = new Payment(new String("veh4"));
		assertTrue(payment4.equals(new Payment(new String("veh4"))));
	}
	
	public void testPaymentEqualsANonPaymentObjectReturnsFalse() {
		assertFalse(new Payment("Name").equals(new Object()));
	}
}
