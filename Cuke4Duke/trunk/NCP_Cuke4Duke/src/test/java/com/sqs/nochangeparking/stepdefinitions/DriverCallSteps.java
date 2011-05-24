package com.sqs.nochangeparking.stepdefinitions;

import cuke4duke.annotation.I18n.EN.*;

public class DriverCallSteps {

	@When("^We get a new call from driver '(.*)'$")
	public void weGetANewCallFromDriver(String name) {
	}

	@When("^He pays to park '(.*)' with a valid credit card$")
	public void hePaysToParkWithAValidCreditCard(String vehicle) {
	}

	@Then("^the payment should be accepted$")
	public void thePaymentShouldBeAccepted() {
	}

	@Then("^the payment should be rejected$")
	public void thePaymentShouldBeRejected() {

	}

	
}
