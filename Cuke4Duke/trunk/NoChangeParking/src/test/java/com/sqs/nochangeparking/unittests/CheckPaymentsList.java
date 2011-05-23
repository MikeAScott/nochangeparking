package com.sqs.nochangeparking.unittests;

import com.sqs.nochangeparking.core.*;
import junit.framework.TestCase;

public class CheckPaymentsList extends TestCase {

	private PaymentsList theList;

	protected void setUp() throws Exception {
		super.setUp();
		theList = new PaymentsList();
	}
	
	public void testCanCreate()
	{
		assertNotNull(theList);
	}
	
	public void testCanAddPayment()
	{
		theList.add("veh1");
		assertTrue(theList.contains("veh1"));
	}
	
	public void testCannotAddSamePayment()
	{
		theList.add("veh2");
		assertFalse(theList.add("veh2"));
		assertEquals(1, theList.size());
	}
	
	public void testCannotAddSameStringPayment()
	{
		String veh2 = new String("veh2");
		theList.add(veh2);
		String veh2asWell = new String("veh2");
		assertTrue("strings not equal", veh2.equals(veh2asWell));
		assertFalse(theList.add(veh2asWell));
		assertEquals(1, theList.size());
	}
	
}

