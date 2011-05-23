package com.sqs.nochangeparking.fitfixtures;

import fitlibrary.SetUpFixture;
import com.sqs.nochangeparking.core.PaymentsList;

public class SetupPaymentsFixture extends SetUpFixture{
	
	private PaymentsList theList;
	
	public SetupPaymentsFixture(PaymentsList theList) {
		this.theList = theList;
		this.theList.clear();
	}
	
	public void vehicle(String veh) {
		theList.AddPayment(veh);
		return;
	}

}
