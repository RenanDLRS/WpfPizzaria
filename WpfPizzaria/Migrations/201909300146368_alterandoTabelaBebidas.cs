namespace WpfPizzaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterandoTabelaBebidas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bebidas", "Preco", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bebidas", "Preco");
        }
    }
}
