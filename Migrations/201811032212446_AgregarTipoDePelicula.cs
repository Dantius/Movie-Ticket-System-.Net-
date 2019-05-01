namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTipoDePelicula : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoDePeliculas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Funcions", "tipoDePeliculaId", c => c.Byte(nullable: false));
            DropColumn("dbo.Funcions", "tipoDePelicula");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Funcions", "tipoDePelicula", c => c.String());
            DropColumn("dbo.Funcions", "tipoDePeliculaId");
            DropTable("dbo.TipoDePeliculas");
        }
    }
}
