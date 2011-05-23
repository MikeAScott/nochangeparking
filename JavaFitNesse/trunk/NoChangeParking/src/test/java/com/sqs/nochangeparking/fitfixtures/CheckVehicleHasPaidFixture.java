package com.sqs.nochangeparking.fitfixtures;

import fit.ColumnFixture;
import com.sqs.nochangeparking.core.PaymentsList;

public class CheckVehicleHasPaidFixture extends ColumnFixture{
	
	private PaymentsList checkTodaysPayments;
	public String Vehicle;
	
	public CheckVehicleHasPaidFixture(PaymentsList theList) {
		checkTodaysPayments = theList;
	}
	
	public boolean Paid() {
		return checkTodaysPayments.hasPaid(Vehicle);
	}

}
