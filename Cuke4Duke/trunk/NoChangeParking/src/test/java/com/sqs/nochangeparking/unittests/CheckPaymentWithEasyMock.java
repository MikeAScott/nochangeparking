package com.sqs.nochangeparking.unittests;

import com.sqs.nochangeparking.core.*;
import org.easymock.classextension.*;
import junit.framework.*;

public class CheckPaymentWithEasyMock extends TestCase {

	public void testCanGetVehicle() {
		final Payment mockPayment = EasyMock.createMock(Payment.class);
		EasyMock.expect(mockPayment.getVehicle()).andReturn("testVehicle").once();

		// Start Mocking
		EasyMock.replay(mockPayment);
		
		assertEquals("testVehicle", mockPayment.getVehicle());
		
		
		EasyMock.verify(mockPayment);
		// End Mocking

	}
}
