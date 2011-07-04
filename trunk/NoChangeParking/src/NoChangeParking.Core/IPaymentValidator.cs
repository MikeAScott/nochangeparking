/*
 * Created by SharpDevelop.
 * User: scottm
 * Date: 29/06/2010
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BigBank.PaymentProcessing
{
	/// <summary>
	/// Description of IPaymentValidator.
	/// </summary>
	public interface IPaymentValidator
	{
		PaymentReceipt ValidatePayment(string cardType, string cardNo, decimal amount);
	}
	
	public class PaymentReceipt {
		
		public bool IsValid {get; private set;}
		public string ReceiptReference {get; private set;}
		public string ValidationMessage {get; private set;}
		
		public PaymentReceipt(bool isValid, string message) {
			this.IsValid = isValid;
			if (isValid) {
				ReceiptReference = message;
				ValidationMessage = "Processed";
			} else {
				ReceiptReference = "";
				ValidationMessage = message;
			}
		}
		
	}
}
