package com.sqs.nochangeparking.fitfixtures;

import com.sqs.nochangeparking.core.*;
import fit.ColumnFixture;

public class CheckApplicationFixture extends ColumnFixture{
	
	public String name() {
		return GreetingServer.getApplicationName();
	}

}
