/*
 * Created by SharpDevelop.
 * User: scottm
 * Date: 29/06/2010
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BigBank.PaymentProcessing
{
	/// <summary>
	/// Description of PaymentValidator.
	/// </summary>
	public class PaymentValidator:IPaymentValidator
	{
		
		public PaymentReceipt ValidatePayment(string cardType, string cardNo, decimal amount)
		{
			throw new NotImplementedException();
		}
	}
}
