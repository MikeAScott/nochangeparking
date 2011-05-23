package com.sqs.nochangeparking.unittests;

import com.sqs.nochangeparking.core.*;
import junit.framework.TestCase;

public class CheckDriversList extends TestCase {
	
	private DriversList theDrivers;
	
	protected void setUp() throws Exception {
		super.setUp();
		theDrivers = new DriversList();
	}
	
	public void testDriverJohnIsNotRegistered() {
		assertNull(theDrivers.findDriver("John"));
	}
	
	public void testDriverJohnIsRegistered() {
		theDrivers.add(new Driver("John"));
		assertEquals(new Driver("John"),theDrivers.findDriver("John"));
	}
	
	public void testRegisteredDriverJohnHasNoCar() {
		theDrivers.add(new Driver("John"));
		Driver theDriverJohn = theDrivers.findDriver("John");
		assertEquals("",theDriverJohn.getDefaultVehicle());
	}
	
	public void testRegisteredDriverJohnHasNoCreditCardNumber() {
		theDrivers.add(new Driver("John"));
		Driver theDriverJohn = theDrivers.findDriver("John");
		assertEquals("",theDriverJohn.getDefaultCreditCard());
	}
	
	public void testDriverJohnRegistersVehicle() {
		theDrivers.add(new Driver("John"));
		Driver theDriverJohn = theDrivers.findDriver("John");
		theDriverJohn.registerVehicle("Car1");
		assertEquals("Car1",theDriverJohn.getDefaultVehicle());
	}
	
	public void testDriverJohnRegistersCreditCardNumber() {
		theDrivers.add(new Driver("John"));
		Driver theDriverJohn = theDrivers.findDriver("John");
		theDriverJohn.registerCard("5232");
		assertEquals("5232",theDriverJohn.getDefaultCreditCard());
	}
	
	public void testRegisterDriverWithAllDetails() {
		theDrivers.add(new Driver("Jackson","CarX","1122"));
		Driver theDriverJackson = theDrivers.findDriver("Jackson");
		assertEquals(new Driver("Jackson","CarX","1122"),theDriverJackson);
	}
	
	public void testDriverEqualsANonPaymentObjectReturnsFalse() {
		assertFalse(new Driver("Name").equals(new Object()));
	}
}