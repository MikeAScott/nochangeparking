package com.sqs.nochangeparking.stepdefinitions;

import com.sqs.nochangeparking.core.ApplicationInfo;

import cuke4duke.annotation.I18n.EN.*;
import static junit.framework.Assert.assertEquals;

public class ApplicationInfoSteps {

	String appName;
	
	@When("^I ask for the application name$")
	public void iAskForTheApplicationName() {
		this.appName = ApplicationInfo.getApplicationName();
	}

	@Then("^the application name should be \"([^\"]*)\"$")
	public void theAppkicationNameShouldBe(String expected) {
		assertEquals(expected, this.appName);
	}
	
}
