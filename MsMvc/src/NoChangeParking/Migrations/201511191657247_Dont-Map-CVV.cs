namespace NoChangeParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DontMapCVV : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PaymentDetails", "CardCVCNumeber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PaymentDetails", "CardCVCNumeber", c => c.String(nullable: false));
        }
    }
}
