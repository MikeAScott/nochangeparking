package com.sqs.nochangeparking.stepdefinitions;

import cuke4duke.annotation.I18n.EN.*;
import cuke4duke.annotation.*;
import static junit.framework.Assert.assertEquals;

public class HelloWorldSteps {

	private String action;
	private String subject;
	
	@Given("^The Action is (.*)$")
	public void theActionIsHello(String action) {
		this.action = action;
	}
	
	@When("^The Subject is (.*)$")
	public void theSubjectIsNinja(String subject) {
		this.subject = subject;
	}

	@Then("^The Greeting is (.*)\\.$")
	public void theGreetingIs(String greeting) {
		assertEquals(greeting, action + ", " + subject);
	}
	
}
