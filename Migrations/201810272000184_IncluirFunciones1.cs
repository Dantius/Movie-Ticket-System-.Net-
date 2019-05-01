namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluirFunciones1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcions",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        horario = c.String(),
                        PeliculaId = c.Byte(nullable: false),
                        Pelicula_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Peliculas", t => t.Pelicula_Id)
                .Index(t => t.Pelicula_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcions", "Pelicula_Id", "dbo.Peliculas");
            DropIndex("dbo.Funcions", new[] { "Pelicula_Id" });
            DropTable("dbo.Funcions");
        }
    }
}
