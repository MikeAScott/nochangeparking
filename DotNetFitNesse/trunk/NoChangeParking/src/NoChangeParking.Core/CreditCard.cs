/*
 * Created by SharpDevelop.
 * User: scottm
 * Date: 29/06/2010
 * Time: 15:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NoChangeParking.Core
{
	/// <summary>
	/// Description of CreditCard.
	/// </summary>
	public class CreditCard
	{
		public string CardType {get ; private set;}
		public string CardNo {get; private set;}
		public string Name {get; private set;}
		
		public CreditCard(string cardType, string cardNo, string name) {
			this.CardType = cardType;
			this.CardNo = cardNo;
			this.Name = name;
		}
	}
}
