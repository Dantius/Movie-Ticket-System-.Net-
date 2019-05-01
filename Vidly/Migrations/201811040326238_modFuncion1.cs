namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modFuncion1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "CantidadDeAsientosAReservar", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservas", "CantidadDeAsientosAReservar");
        }
    }
}
