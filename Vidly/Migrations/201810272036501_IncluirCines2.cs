namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluirCines2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cines",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nombre = c.String(),
                        PeliculaId = c.Byte(nullable: false),
                        FuncionId = c.Byte(nullable: false),
                        SalaId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Funcions", "Nombre", c => c.String());
            AddColumn("dbo.Salas", "Nombre", c => c.String());
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Complejoes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Salas", "Nombre");
            DropColumn("dbo.Funcions", "Nombre");
            DropTable("dbo.Cines");
        }
    }
}
