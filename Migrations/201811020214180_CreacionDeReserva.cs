namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionDeReserva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Funcion_Id = c.Byte(),
                        Pelicula_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Funcions", t => t.Funcion_Id)
                .ForeignKey("dbo.Peliculas", t => t.Pelicula_Id)
                .Index(t => t.Funcion_Id)
                .Index(t => t.Pelicula_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Pelicula_Id", "dbo.Peliculas");
            DropForeignKey("dbo.Reservas", "Funcion_Id", "dbo.Funcions");
            DropIndex("dbo.Reservas", new[] { "Pelicula_Id" });
            DropIndex("dbo.Reservas", new[] { "Funcion_Id" });
            DropTable("dbo.Reservas");
        }
    }
}
