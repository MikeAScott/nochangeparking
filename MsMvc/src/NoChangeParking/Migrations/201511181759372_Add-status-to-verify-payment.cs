namespace NoChangeParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addstatustoverifypayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VerifyPayments", "StatusMessage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VerifyPayments", "StatusMessage");
        }
    }
}
