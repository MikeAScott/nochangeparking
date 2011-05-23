package com.sqs.nochangeparking.core;

public class Payment {
	
	private String vehicle;
	
	public Payment(String vehicle) {
		this.vehicle = vehicle;
	}
	
	public String getVehicle() {
		return vehicle;
	}
	
	public boolean equals(Object o) {
		if (!(o instanceof Payment)) {
			return false;
		}
		Payment p = (Payment)o;
		return (this.vehicle.equals(p.vehicle));
	}

}
