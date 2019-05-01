namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configurarTablas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Funcions", "Pelicula_Id", "dbo.Peliculas");
            DropForeignKey("dbo.Salas", "FuncionId", "dbo.Funcions");
            DropIndex("dbo.Funcions", new[] { "Pelicula_Id" });
            DropIndex("dbo.Salas", new[] { "FuncionId" });
            DropTable("dbo.Funcions");
            DropTable("dbo.Salas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nombre = c.String(),
                        FuncionId = c.Byte(nullable: false),
                        asiento1 = c.Boolean(),
                        asiento2 = c.Boolean(),
                        asiento3 = c.Boolean(),
                        asiento4 = c.Boolean(),
                        asiento5 = c.Boolean(),
                        asiento6 = c.Boolean(),
                        asiento7 = c.Boolean(),
                        asiento8 = c.Boolean(),
                        asiento9 = c.Boolean(),
                        asiento10 = c.Boolean(),
                        asiento11 = c.Boolean(),
                        asiento12 = c.Boolean(),
                        asiento13 = c.Boolean(),
                        asiento14 = c.Boolean(),
                        asiento15 = c.Boolean(),
                        asiento16 = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcions",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nombre = c.String(),
                        horario = c.String(),
                        PeliculaId = c.Byte(nullable: false),
                        Pelicula_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Salas", "FuncionId");
            CreateIndex("dbo.Funcions", "Pelicula_Id");
            AddForeignKey("dbo.Salas", "FuncionId", "dbo.Funcions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Funcions", "Pelicula_Id", "dbo.Peliculas", "Id");
        }
    }
}
