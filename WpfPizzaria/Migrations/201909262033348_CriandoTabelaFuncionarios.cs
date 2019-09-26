namespace WpfPizzaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoTabelaFuncionarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        cargoFuncionario = c.Int(nullable: false),
                        CriadoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionarios");
        }
    }
}
