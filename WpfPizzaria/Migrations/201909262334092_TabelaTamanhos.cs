namespace WpfPizzaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaTamanhos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tamanhos",
                c => new
                    {
                        TamanhoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TamanhoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tamanhos");
        }
    }
}
