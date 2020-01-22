namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameInPlan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Planoes", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Planoes", "Name", c => c.String());
        }
    }
}
