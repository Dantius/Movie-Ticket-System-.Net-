namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modFuncion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcions", "SalaId", c => c.Byte(nullable: false));
            AddColumn("dbo.Funcions", "Sala_Id", c => c.Int());
            CreateIndex("dbo.Funcions", "Sala_Id");
            AddForeignKey("dbo.Funcions", "Sala_Id", "dbo.Salas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcions", "Sala_Id", "dbo.Salas");
            DropIndex("dbo.Funcions", new[] { "Sala_Id" });
            DropColumn("dbo.Funcions", "Sala_Id");
            DropColumn("dbo.Funcions", "SalaId");
        }
    }
}
