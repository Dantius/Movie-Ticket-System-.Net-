namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopularSalas : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Salas(Id,Nombre,FuncionId) VALUES(1,'Sala A',1)");
            Sql("INSERT INTO Salas(Id,Nombre,FuncionId) VALUES(2,'Sala A',2)");

        }

        public override void Down()
        {
        }
    }
}
