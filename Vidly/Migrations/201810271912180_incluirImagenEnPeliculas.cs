namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class incluirImagenEnPeliculas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Peliculas", "imagen", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Peliculas", "imagen");
        }
    }
}
