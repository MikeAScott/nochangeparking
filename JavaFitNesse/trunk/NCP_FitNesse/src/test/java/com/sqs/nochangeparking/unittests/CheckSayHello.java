package com.sqs.nochangeparking.unittests;

import junit.framework.*;
import com.sqs.nochangeparking.core.*;

public class CheckSayHello extends TestCase{
	
	public void testSayHelloReturnsChuck() {
		assertEquals("Hello Chuck", GreetingServer.sayHello("Chuck"));
	}
	
	public void testSayHelloWithNoNameReturnsHelloStranger() {
		assertEquals("Hello Stranger", GreetingServer.sayHello(""));
	}

}
