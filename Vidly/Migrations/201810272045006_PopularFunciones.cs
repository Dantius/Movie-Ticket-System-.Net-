namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopularFunciones : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Funcions(Id,Nombre,Horario, PeliculaId) VALUES(1,'Matutina',   '11:00', 1)");
            Sql("INSERT INTO Funcions(Id,Nombre,Horario, PeliculaId) VALUES(2, 'Vespertina', '16:35', 1)");
            Sql("INSERT INTO Funcions(Id,Nombre,Horario, PeliculaId) VALUES(3,'Nocturna',   '21:15', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
