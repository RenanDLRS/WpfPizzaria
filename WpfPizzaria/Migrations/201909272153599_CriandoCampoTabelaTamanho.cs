namespace WpfPizzaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoCampoTabelaTamanho : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tamanhos", "QtdSabores", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tamanhos", "QtdSabores");
        }
    }
}
