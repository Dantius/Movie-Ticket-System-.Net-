namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluirSalas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        FuncionId = c.Byte(nullable: false),
                        asiento1 = c.Boolean(nullable: false),
                        asiento2 = c.Boolean(nullable: false),
                        asiento3 = c.Boolean(nullable: false),
                        asiento4 = c.Boolean(nullable: false),
                        asiento5 = c.Boolean(nullable: false),
                        asiento6 = c.Boolean(nullable: false),
                        asiento7 = c.Boolean(nullable: false),
                        asiento8 = c.Boolean(nullable: false),
                        asiento9 = c.Boolean(nullable: false),
                        asiento10 = c.Boolean(nullable: false),
                        asiento11 = c.Boolean(nullable: false),
                        asiento12 = c.Boolean(nullable: false),
                        asiento13 = c.Boolean(nullable: false),
                        asiento14 = c.Boolean(nullable: false),
                        asiento15 = c.Boolean(nullable: false),
                        asiento16 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Funcions", t => t.FuncionId, cascadeDelete: true)
                .Index(t => t.FuncionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salas", "FuncionId", "dbo.Funcions");
            DropIndex("dbo.Salas", new[] { "FuncionId" });
            DropTable("dbo.Salas");
        }
    }
}
