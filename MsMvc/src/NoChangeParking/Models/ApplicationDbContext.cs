using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoChangeParking.Models
{
     public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<NoChangeParking.Models.PaymentDetails> PaymentDetails { get; set; }

        public System.Data.Entity.DbSet<NoChangeParking.Models.VerifyPayments> VerifyPayments { get; set; }

    }
}