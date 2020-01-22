namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlimentarTabelaPlanoes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Planoes Values ('Plano A', 60)");
            Sql("INSERT INTO Planoes Values ('Plano B', 80)");
            Sql("INSERT INTO Planoes Values ('Plano C', 100)");
        }
        
        public override void Down()
        {
        }
    }
}
