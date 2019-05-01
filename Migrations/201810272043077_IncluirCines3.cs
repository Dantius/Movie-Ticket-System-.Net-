namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluirCines3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cines", "Pelicula_Id", c => c.Int());
            AddColumn("dbo.Cines", "Sala_Id", c => c.Byte());
            AlterColumn("dbo.Peliculas", "Nombre", c => c.String(maxLength: 255));
            CreateIndex("dbo.Cines", "FuncionId");
            CreateIndex("dbo.Cines", "Pelicula_Id");
            CreateIndex("dbo.Cines", "Sala_Id");
            AddForeignKey("dbo.Cines", "FuncionId", "dbo.Funcions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cines", "Pelicula_Id", "dbo.Peliculas", "Id");
            AddForeignKey("dbo.Cines", "Sala_Id", "dbo.Salas", "Id");
            DropColumn("dbo.Cines", "SalaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cines", "SalaId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Cines", "Sala_Id", "dbo.Salas");
            DropForeignKey("dbo.Cines", "Pelicula_Id", "dbo.Peliculas");
            DropForeignKey("dbo.Cines", "FuncionId", "dbo.Funcions");
            DropIndex("dbo.Cines", new[] { "Sala_Id" });
            DropIndex("dbo.Cines", new[] { "Pelicula_Id" });
            DropIndex("dbo.Cines", new[] { "FuncionId" });
            AlterColumn("dbo.Peliculas", "Nombre", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Cines", "Sala_Id");
            DropColumn("dbo.Cines", "Pelicula_Id");
        }
    }
}
