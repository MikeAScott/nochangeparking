package com.sqs.nochangeparking.fitfixtures;

import fit.ColumnFixture;

public class CheckAdditionFixture extends ColumnFixture{
	
	public Integer lhs;
	public Integer rhs;
	
	public Integer result() {
		return lhs + rhs;
	}

}
