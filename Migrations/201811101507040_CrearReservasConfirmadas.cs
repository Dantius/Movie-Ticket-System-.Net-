namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearReservasConfirmadas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservasConfirmadas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        asiento1 = c.Byte(nullable: false),
                        asiento2 = c.Byte(nullable: false),
                        asiento3 = c.Byte(nullable: false),
                        FuncionId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Funcions", t => t.FuncionId, cascadeDelete: true)
                .Index(t => t.FuncionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservasConfirmadas", "FuncionId", "dbo.Funcions");
            DropIndex("dbo.ReservasConfirmadas", new[] { "FuncionId" });
            DropTable("dbo.ReservasConfirmadas");
        }
    }
}
