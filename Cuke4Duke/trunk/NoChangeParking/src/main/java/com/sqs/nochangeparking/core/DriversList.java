package com.sqs.nochangeparking.core;

import java.util.ArrayList;

public class DriversList extends ArrayList<Driver>{
	
	private static final long serialVersionUID = 1L;
	
	public boolean add(String driver, String vehicle, String CcNo) {
		return super.add(new Driver(driver,vehicle,CcNo));
	}
	
	public boolean add(String driver) {
		return super.add(new Driver(driver));
	}

	public Driver findDriver(String name) {
		Driver theDriver;
		for (int i=0;i<super.size();i++) {
			theDriver = super.get(i);
			if (theDriver.getName().equals(name))
				return theDriver;
		}
		return null;
	}
	
	public boolean containsDriver(Driver driver) {
		return findDriver(driver.getName()) != null;
	}
}
