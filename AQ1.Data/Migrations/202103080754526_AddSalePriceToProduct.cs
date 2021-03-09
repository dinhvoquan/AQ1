namespace AQ1.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalePriceToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SalePrice", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "SalePrice");
        }
    }
}
