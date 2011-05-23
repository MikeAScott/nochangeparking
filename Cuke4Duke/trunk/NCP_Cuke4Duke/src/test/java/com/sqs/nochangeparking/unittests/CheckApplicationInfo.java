package com.sqs.nochangeparking.unittests;

import com.sqs.nochangeparking.core.*;
import junit.framework.TestCase;

public class CheckApplicationInfo extends TestCase{

	private GreetingServer theServer;
	
	protected void setUp() throws Exception
	{
		super.setUp();
		theServer = GreetingServer.getInstance();
	}
	
	public void testCanCreate()
	{
		assertNotNull(theServer);
	}
	
	public void testClassIsASingleton()
	{
		assertEquals(theServer, GreetingServer.getInstance());
	}
	
	public void testApplicationNameIsNoChangeParking() {
		assertEquals("NoChangeParking", GreetingServer.getApplicationName());
	}
	
}
