using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NoChangeParking.Models
{
    public class PaymentDetails
    {

        public int Id { get; set; }

        [DisplayName("Registration Number")]
        [Required]
        [RegularExpression(@"^[\s\S]{0,7}[ ]{0,1}[\s\S]{0,7}$", ErrorMessage = "Registration Number should be Alphanumeric and uppercase characters only")]
        public string RegistrationPlate { get; set; }

        [DisplayName("Name On Card")]
        [Required]
        [RegularExpression(@"^[\s\S]{0,15}[ ]{0,1}[\s\S]{0,15}$", ErrorMessage = "Name field should contain Full Name, letters and spaces only")]
        public string NameOnCard { get; set; }

        [Display (Name = "Card Type")]
        [Required]
        public CardTypes CardType { get; set; }


        [DisplayName("Card Number")]
        [Required]
        [RegularExpression(@"^[0-9]{0,4}[ ]{0,1}[0-9]{0,4}[ ]{0,1}[0-9]{0,4}[ ]{0,1}[0-9]{0,4}[ ]{0,1}$", ErrorMessage = "Card number should be 16 digits")]
        public string CardNumber { get; set; }

        [DisplayName("Card Expiry")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:mm/yyyy}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^(0[1-9]|1[012])/\d{2}$", ErrorMessage = "End Date should be in MM/YY format")]
        public string CardExpiry { get; set; }

        [DisplayName("CVV")]
        [Required]
        [RegularExpression(@"^[0-9][0-9][0-9]$", ErrorMessage = "CVV must be 3 digits")]
        [NotMapped]
        public string CardCVCNumeber { get; set; }

        [DisplayName("Card Issue Number")]
        [RegularExpression(@"^[0-9][0-9]$", ErrorMessage = "Issue number must be 2 digits")]
        public string CardIssueNumeber { get; set; }

        [DisplayName("Payment Reference")]
        public string PaymentReference { get; set; }
        
        //public CardTypes CardType { get; set; }
    }
}