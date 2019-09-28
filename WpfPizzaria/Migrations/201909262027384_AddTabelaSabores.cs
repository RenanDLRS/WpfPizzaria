namespace WpfPizzaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTabelaSabores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sabores",
                c => new
                    {
                        SaborId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SaborId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sabores");
        }
    }
}
