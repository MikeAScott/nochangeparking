package com.sqs.nochangeparking.stepdefinitions;

import com.sqs.nochangeparking.core.CallCentre;

public class CallCentreContext {
	
	private CallCentre _theCallCentre;
	
	public CallCentreContext() {
		_theCallCentre = new CallCentre();
	}
	
	public CallCentre getTheCallCentre(){
		return _theCallCentre;
	}
	

}
