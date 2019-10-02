namespace WpfPizzaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableItemSabores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemSabores",
                c => new
                    {
                        IdItemSabor = c.Int(nullable: false, identity: true),
                        Sabor_SaborId = c.Int(),
                        Pizza_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdItemSabor)
                .ForeignKey("dbo.Sabores", t => t.Sabor_SaborId)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_Id)
                .Index(t => t.Sabor_SaborId)
                .Index(t => t.Pizza_Id);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tamanho_TamanhoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tamanhos", t => t.Tamanho_TamanhoId)
                .Index(t => t.Tamanho_TamanhoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pizzas", "Tamanho_TamanhoId", "dbo.Tamanhos");
            DropForeignKey("dbo.ItemSabores", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.ItemSabores", "Sabor_SaborId", "dbo.Sabores");
            DropIndex("dbo.Pizzas", new[] { "Tamanho_TamanhoId" });
            DropIndex("dbo.ItemSabores", new[] { "Pizza_Id" });
            DropIndex("dbo.ItemSabores", new[] { "Sabor_SaborId" });
            DropTable("dbo.Pizzas");
            DropTable("dbo.ItemSabores");
        }
    }
}
