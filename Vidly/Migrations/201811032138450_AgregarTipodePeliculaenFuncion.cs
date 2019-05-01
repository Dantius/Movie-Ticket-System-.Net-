namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTipodePeliculaenFuncion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcions", "tipoDePelicula", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcions", "tipoDePelicula");
        }
    }
}
