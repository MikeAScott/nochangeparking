package com.sqs.nochangeparking.core;

import java.util.ArrayList;

public class PaymentsList extends ArrayList<Payment>{
	
	private static final long serialVersionUID = 1L;


//	private PaymentsList():base(new List<Payment>()){/*NOOP*/}

	public boolean add(String vehicle) {
		if (contains(vehicle))
			return false;
		return super.add(new Payment(vehicle));
	}
	
	public boolean contains(String vehicle) {
		return contains(new Payment(vehicle));
	}
	
	public boolean hasPaid(String vehicle) {
		return contains(new Payment(vehicle));
	}
	
	public void AddPayment(String vehicle) {
		if (hasPaid(vehicle)) return;
		this.add(vehicle);
	}
	
}
