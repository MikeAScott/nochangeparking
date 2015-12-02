namespace NoChangeParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentDetails : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PaymentDetails", "CardNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PaymentDetails", "CardNumber", c => c.Int(nullable: false));
        }
    }
}
