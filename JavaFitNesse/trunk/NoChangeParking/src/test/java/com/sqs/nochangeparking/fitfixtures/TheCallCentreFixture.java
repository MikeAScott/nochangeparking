package com.sqs.nochangeparking.fitfixtures;

import fit.Fixture;
import fitlibrary.DoFixture;
import fitlibrary.SetFixture;

import com.sqs.nochangeparking.core.CallCentre;

public class TheCallCentreFixture extends DoFixture{

	private CallCentre _theCallCentre;
	
	public TheCallCentreFixture() {
		_theCallCentre = CallCentre.getInstance();
		this.systemUnderTest = _theCallCentre;
	}

	public Fixture setupPayments() {
		return new SetupPaymentsFixture(_theCallCentre.getTodaysPayments());
	}
	public Fixture setupDefaults() {
		return new SetupDefaultsFixture(_theCallCentre);
	}
	
	public Fixture todaysPayments() {
		return new SetFixture(_theCallCentre.getTodaysPayments());
	}	
}

