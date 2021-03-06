namespace ShoppingCartDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeID : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "CategoryId", c => c.String());
        }
    }
}
