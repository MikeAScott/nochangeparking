namespace NoChangeParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentReference : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentDetails", "PaymentReference", c => c.String());
            AlterColumn("dbo.PaymentDetails", "CardCVCNumeber", c => c.String(nullable: false));
            AlterColumn("dbo.PaymentDetails", "CardIssueNumeber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PaymentDetails", "CardIssueNumeber", c => c.Int(nullable: false));
            AlterColumn("dbo.PaymentDetails", "CardCVCNumeber", c => c.Int(nullable: false));
            DropColumn("dbo.PaymentDetails", "PaymentReference");
        }
    }
}
