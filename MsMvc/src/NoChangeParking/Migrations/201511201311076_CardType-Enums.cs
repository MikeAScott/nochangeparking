namespace NoChangeParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardTypeEnums : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PaymentDetails", "CardType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PaymentDetails", "CardType", c => c.String(nullable: false));
        }
    }
}
