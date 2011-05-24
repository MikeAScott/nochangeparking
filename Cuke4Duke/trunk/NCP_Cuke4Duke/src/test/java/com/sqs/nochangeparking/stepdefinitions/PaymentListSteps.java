package com.sqs.nochangeparking.stepdefinitions;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import com.sqs.nochangeparking.core.Payment;
import com.sqs.nochangeparking.core.PaymentsList;

import cuke4duke.annotation.I18n.EN.*;

public class PaymentListSteps {

	private CallCentreContext _context;
	
	public PaymentListSteps(CallCentreContext context) {
		_context = context;
	}
	
	@Given("^The following payments list$")
	public void theFollowingPaymentsList(cuke4duke.Table table) {
		PaymentsList todaysPayments = _context.getTheCallCentre().getTodaysPayments();
		for(List<String> row: table.rows()){
			todaysPayments.add(new Payment(row.get(0)));
		}
	}
	
	@Then("^the payments list should show$")
	public void thePaymentsListShouldShowWithTable(cuke4duke.Table table) {	
		PaymentsList todaysPayments = _context.getTheCallCentre().getTodaysPayments();
		List<Map<String,String>> actualPayments=new ArrayList<Map<String,String>>();
		for (Payment payment:todaysPayments){
			actualPayments.add(toHash(payment));
			
	    }   
		table.diffHashes(actualPayments);
	 }
	
	 private Map<String,String> toHash(Payment payment){
	   Map<String,String> map=new HashMap<String,String>();
	   map.put("Vehicle",payment.getVehicle());
	   return map;
	 }
	

	 @Then("^'(.*)' should show as paid$")
	 public void vehicleShouldShowAsPaid(String vehicle) {
	 }

	 @Then("^'(.*)' should show as not paid$")
	 public void vehicleShouldShowAsNotPaid(String vehicle) {

	 }

}
