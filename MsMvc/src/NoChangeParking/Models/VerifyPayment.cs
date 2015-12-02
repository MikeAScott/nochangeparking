using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NoChangeParking.Models
{
     public class VerifyPayments
     {

          public int Id { get; set; }

          [DisplayName("Registration Plate")]
          [Required]
          [RegularExpression(@"^[a-zA-Z-0-9\s]{0,30}$", ErrorMessage = "Registration Plate should be Alphanumeric only")]
          public string RegistrationPlate { get; set; }

          public string ValidStatusMessage { get; set;  }
        public string InValidStatusMessage { get; set; }
    }
}    