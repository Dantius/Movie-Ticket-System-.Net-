namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteCine : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cines", "Pelicula_Id", "dbo.Peliculas");
            DropForeignKey("dbo.Cines", "Sala_Id", "dbo.Salas");
            DropIndex("dbo.Cines", new[] { "Pelicula_Id" });
            DropIndex("dbo.Cines", new[] { "Sala_Id" });
            DropTable("dbo.Cines");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Cines",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nombre = c.String(),
                        PeliculaId = c.Byte(nullable: false),
                        Pelicula_Id = c.Int(),
                        Sala_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Cines", "Sala_Id");
            CreateIndex("dbo.Cines", "Pelicula_Id");
            AddForeignKey("dbo.Cines", "Sala_Id", "dbo.Salas", "Id");
            AddForeignKey("dbo.Cines", "Pelicula_Id", "dbo.Peliculas", "Id");
        }
    }
}
