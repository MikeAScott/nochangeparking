namespace NoChangeParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VerifyPaymentsremovespaces : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VerifyPayments", "RegistrationPlate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VerifyPayments", "RegistrationPlate", c => c.String());
        }
    }
}
