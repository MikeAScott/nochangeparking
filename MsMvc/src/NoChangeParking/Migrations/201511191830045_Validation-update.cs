namespace NoChangeParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validationupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VerifyPayments", "ValidStatusMessage", c => c.String());
            AddColumn("dbo.VerifyPayments", "InValidStatusMessage", c => c.String());
            AlterColumn("dbo.PaymentDetails", "CardExpiry", c => c.String(nullable: false));
            DropColumn("dbo.VerifyPayments", "StatusMessage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VerifyPayments", "StatusMessage", c => c.String());
            AlterColumn("dbo.PaymentDetails", "CardExpiry", c => c.Int(nullable: false));
            DropColumn("dbo.VerifyPayments", "InValidStatusMessage");
            DropColumn("dbo.VerifyPayments", "ValidStatusMessage");
        }
    }
}
