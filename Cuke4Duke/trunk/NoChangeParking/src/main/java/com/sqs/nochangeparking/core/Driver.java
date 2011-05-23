package com.sqs.nochangeparking.core;

public class Driver {
	
	private String name;
	private String defaultVehicle;
	private String defaultCreditCard;
	
	public Driver(String driver) {
		this.name = driver;
		this.defaultVehicle = "";
		this.defaultCreditCard = "";
	}
	
	public Driver(String driver, String vehicle, String ccNo) {
		this.name = driver;
		this.defaultVehicle = vehicle;
		this.defaultCreditCard = ccNo;
	}
	
	public boolean equals(Object o) {
        if (!(o instanceof Driver))
            return false;
        Driver p = (Driver)o;
        return (this.name.equals(p.name));
    }
	
	public String getDefaultVehicle() {
		return this.defaultVehicle;
	}
	
	public String getDefaultCreditCard() {
		return this.defaultCreditCard;
	}
	
	public String getName() {
		return this.name;
	}
	
/* Below here to be moved */
	
	private boolean useDefaultVehicle;
	private boolean useDefaultCard;

	public boolean registerVehicle(String vehicle) {
		this.defaultVehicle = vehicle;
		return true;
	}
	
	public boolean registerCard(String ccNo) {
		this.defaultCreditCard = ccNo;
		return true;
	}
	
	public String promptMessage() {
		if (!(this.defaultVehicle == "")) {
			return "Do you wish to park " + this.defaultVehicle + "?";
		} else {
			return "Enter your Vehicle registration";
		}
	}
	
	public boolean selectDefaultVehicle(boolean useDefault) {
		this.useDefaultVehicle = useDefault;
		return this.useDefaultVehicle;
	}
	
	public boolean selectDefaultCard(boolean useDefault) {
		this.useDefaultCard = useDefault;
		return this.useDefaultCard;
	}
	
	public String vehicle() {
		if (this.useDefaultVehicle) {
			return this.defaultVehicle;
		} else
			return "";
	}
	
	public String creditCard() {
		if (this.useDefaultCard) {
			return this.defaultCreditCard;
		} else
			return "";
	}
	
	public void setUseDefaultVehicle(Boolean settingParameter) {
		this.useDefaultVehicle = settingParameter;
	}
	
	public void setUseDefaultCard(boolean settingParameter) {
		this.useDefaultCard = settingParameter;
	}
	
	public boolean getUseDefaultVehicle() {
		return this.useDefaultVehicle;
	}
	
	public boolean getUseDefaultCard() {
		return this.useDefaultCard;
	}
}