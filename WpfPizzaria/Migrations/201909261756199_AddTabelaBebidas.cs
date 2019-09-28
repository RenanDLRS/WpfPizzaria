namespace WpfPizzaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTabelaBebidas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bebidas",
                c => new
                    {
                        BebidaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BebidaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bebidas");
        }
    }
}
