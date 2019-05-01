namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aplicarAnotacionesAPeliculas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Peliculas", "Nombre", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Peliculas", "Descripcion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Peliculas", "Descripcion", c => c.String());
            AlterColumn("dbo.Peliculas", "Nombre", c => c.String());
        }
    }
}
