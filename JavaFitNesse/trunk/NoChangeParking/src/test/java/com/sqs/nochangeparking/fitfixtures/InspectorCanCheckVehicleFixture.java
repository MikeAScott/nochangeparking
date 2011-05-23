package com.sqs.nochangeparking.fitfixtures;

import fitlibrary.DoFixture;
import fit.ColumnFixture;
import fit.Fixture;

import com.sqs.nochangeparking.core.PaymentsList;

public class InspectorCanCheckVehicleFixture extends DoFixture {
	
	private PaymentsList checkTodaysPayments;
	
	public InspectorCanCheckVehicleFixture() {
		checkTodaysPayments = new PaymentsList();
		this.systemUnderTest = checkTodaysPayments;
	}
	
	public Fixture setupPaymentsList() {
		return new SetupPaymentsFixture(checkTodaysPayments);
	}
	
	public ColumnFixture checkVehicleHasPaid() {
		CheckVehicleHasPaidFixture checkIsPaidFixture = new CheckVehicleHasPaidFixture(checkTodaysPayments);
		return checkIsPaidFixture;
	}
}
