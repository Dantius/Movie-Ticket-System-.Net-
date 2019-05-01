namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarCines : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cines", "FuncionId", "dbo.Funcions");
            DropIndex("dbo.Cines", new[] { "FuncionId" });
            DropColumn("dbo.Cines", "FuncionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cines", "FuncionId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Cines", "FuncionId");
            AddForeignKey("dbo.Cines", "FuncionId", "dbo.Funcions", "Id", cascadeDelete: true);
        }
    }
}
