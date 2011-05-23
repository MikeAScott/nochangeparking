package com.sqs.nochangeparking.fitfixtures;

import fitlibrary.SetUpFixture;
import com.sqs.nochangeparking.core.PaymentsList;

public class SetupPaymentsListFixture extends SetUpFixture{
	
	private PaymentsList theList;
	
	public SetupPaymentsListFixture(PaymentsList theList) {
		this.theList = theList;
		this.theList.clear();
	}
	
	public boolean vehicle(String veh) {
		return theList.add(veh);
	}

}
