namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MdSalas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Asientoes", "SalaId", c => c.Byte(nullable: false));
            AddColumn("dbo.Asientoes", "Sala_Id", c => c.Int());
            CreateIndex("dbo.Asientoes", "Sala_Id");
            AddForeignKey("dbo.Asientoes", "Sala_Id", "dbo.Salas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Asientoes", "Sala_Id", "dbo.Salas");
            DropIndex("dbo.Asientoes", new[] { "Sala_Id" });
            DropColumn("dbo.Asientoes", "Sala_Id");
            DropColumn("dbo.Asientoes", "SalaId");
        }
    }
}
