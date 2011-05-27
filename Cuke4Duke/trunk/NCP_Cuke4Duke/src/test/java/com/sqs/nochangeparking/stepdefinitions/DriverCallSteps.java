package com.sqs.nochangeparking.stepdefinitions;

import com.sqs.nochangeparking.core.DriverCall;

import cuke4duke.annotation.I18n.EN.*;
import cuke4duke.annotation.*;
import static junit.framework.Assert.assertTrue;
import static junit.framework.Assert.assertFalse;


public class DriverCallSteps {
	
	private CallCentreContext _context;
	private DriverCall _theCall;
	private boolean _accepted;
	
	public DriverCallSteps(CallCentreContext context) {
		_context = context;
	}

	@When("^We get a new call from driver '(.*)'$")
	public void weGetANewCallFromDriver(String driver) {
		_theCall = _context.getTheCallCentre().newCallFromDriver(driver);
	}

	@When("^He pays to park '(.*)' with a valid credit card$")
	public void hePaysToParkWithAValidCreditCard(String vehicle) {
		_accepted = _theCall.payForVehicleWithCreditCard(vehicle, "1234567890");
	}

	@Then("^the payment should be accepted$")
	public void thePaymentShouldBeAccepted() {
		assertTrue("Payment should be accepted",_accepted);
	}

	@Then("^the payment should be rejected$")
	public void thePaymentShouldBeRejected() {
		assertFalse("Payment should be rejected",_accepted);
	}


	
}
