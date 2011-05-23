package com.sqs.nochangeparking.unittests;

import junit.framework.Test;
import junit.framework.TestSuite;

public class AllTests {

	public static Test suite() {
		TestSuite suite = new TestSuite(
				"Test for com.sqs.nochangeparking.unittests");
		//$JUnit-BEGIN$
		suite.addTestSuite(CheckPaymentsList.class);
		suite.addTestSuite(CheckSayHello.class);
		suite.addTestSuite(CheckPaymentWithEasyMock.class);
		suite.addTestSuite(CheckDriversList.class);
		suite.addTestSuite(CheckApplicationInfo.class);
		suite.addTestSuite(CheckVehicleHasPaid.class);
		suite.addTestSuite(CheckPayment.class);
		suite.addTestSuite(CheckUseDefaultDetails.class);
		//$JUnit-END$
		return suite;
	}

}
