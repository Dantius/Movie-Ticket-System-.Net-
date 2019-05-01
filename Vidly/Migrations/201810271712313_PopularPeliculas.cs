namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopularPeliculas : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Peliculas(Nombre, Descripcion,FechaDeEstreno) VALUES ('Venom', 'Una de Marvel', '01/09/2018')");
            Sql("INSERT INTO Peliculas(Nombre, Descripcion,FechaDeEstreno) VALUES ('Captain Marvel', 'Otra de Marvel', '16/05/2019')");
            Sql("INSERT INTO Peliculas(Nombre, Descripcion,FechaDeEstreno) VALUES ('Black Panther', 'Y Otra mas de Marvel', '16/05/2019')");
        }
        
        public override void Down()
        {
        }
    }
}
