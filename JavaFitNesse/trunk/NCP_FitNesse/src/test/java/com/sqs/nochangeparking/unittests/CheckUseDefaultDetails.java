package com.sqs.nochangeparking.unittests;

import com.sqs.nochangeparking.core.DriversList;
import com.sqs.nochangeparking.core.Driver;

import junit.framework.TestCase;

public class CheckUseDefaultDetails extends TestCase {

	private DriversList theDriversList;
	private Driver theDriver;

	protected void setUp() throws Exception {
		super.setUp();
		theDriversList = new DriversList();
	}
	
	public void testDriverJohnIsRegistered() {
		theDriversList.add(new Driver("John"));
		theDriver = theDriversList.findDriver("John");
		assertEquals("John",theDriver.getName());
	}
	
	public void testDriverJohnCanRetrieveDefaultVehicle() {
		theDriversList.add(new Driver("John","Car1","5232"));
		theDriver = theDriversList.findDriver("John");
		assertEquals("Car1",theDriver.getDefaultVehicle());
	}
	
	public void testDriverJohnCanRetrieveDefaultCCNo() {
		theDriversList.add(new Driver("John","Car1","5232"));
		theDriver = theDriversList.findDriver("John");
		assertEquals("5232",theDriver.getDefaultCreditCard());
	}
	
	public void testUnregisteredDriverJaneCanNotReceiveDefaultVehicle() {
		theDriversList.add("Jane");
		theDriver = theDriversList.findDriver("Jane");
		assertEquals("",theDriver.getDefaultVehicle());
	}
	
	public void testUnregisteredDriverJaneCanNotReceiveDefaultCreditCard() {
		theDriversList.add("Jane");
		theDriver = theDriversList.findDriver("Jane");
		assertEquals("",theDriver.getDefaultCreditCard());
	}
	
	public void testPromptMessageReturnsUseOfDefaultCar() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		assertEquals("Do you wish to park Car1?",theDriver.promptMessage());
	}
	
	public void testPromptMessageReturnsRegisterNewCarPrompt() {
		theDriversList.add("John");
		theDriver = theDriversList.findDriver("John");
		assertEquals("Enter your Vehicle registration",theDriver.promptMessage());
	}
	
	public void testDriverSelectsDefaultVehicle() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		assertEquals(true,theDriver.selectDefaultVehicle(true));
	}
	
	public void testDriverDoesNotSelectDefaultVehicle() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		assertEquals(false,theDriver.selectDefaultVehicle(false));
	}
	
	public void testDriverSelectsDefaultCard() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		assertEquals(true,theDriver.selectDefaultCard(true));
	}
	
	public void testDriverDoesNotSelectDefaultCard() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		assertEquals(false,theDriver.selectDefaultCard(false));
	}
	
	public void testCanSetandGetDefaultVehicleToTrue() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		theDriver.setUseDefaultVehicle(true);
		assertEquals(true,theDriver.getUseDefaultVehicle());
	}
	
	public void testCanSetandGetDefaultCardToTrue() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		theDriver.setUseDefaultCard(true);
		assertEquals(true,theDriver.getUseDefaultCard());
	}
	
	public void testCanRetrieveDefaultVehicleForDriverJohn() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		theDriver.setUseDefaultVehicle(true);
		assertEquals("Car1",theDriver.vehicle());
	}
	
	public void testCanNotRetrieveDefaultVehicleForDriverJohn() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		theDriver.setUseDefaultVehicle(false);
		assertNotNull("Car1",theDriver.vehicle());
	}
	
	public void testCanRetrieveDefaultCardForDriverJohn() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		theDriver.setUseDefaultCard(true);
		assertEquals("CCNum",theDriver.creditCard());
	}
	
	public void testCanNotRetrieveDefaultCardForDriverJohn() {
		theDriversList.add("John","Car1","CCNum");
		theDriver = theDriversList.findDriver("John");
		theDriver.setUseDefaultCard(false);
		assertNotNull("CCNum",theDriver.creditCard());
	}
	
	public void testFindUnknownDriverReturnsNull() {
		theDriversList.add("John","Car1","CCNum1");
		theDriversList.add("Jane","Car2","CCNum2");
		theDriversList.add("James","Car3","CCNum3");
		theDriver = theDriversList.findDriver("unknown");
		assertNull(theDriver);
	}
}
