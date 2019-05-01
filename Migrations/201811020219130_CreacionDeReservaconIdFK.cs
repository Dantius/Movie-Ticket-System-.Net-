namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionDeReservaconIdFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservas", "Funcion_Id", "dbo.Funcions");
            DropIndex("dbo.Reservas", new[] { "Funcion_Id" });
            RenameColumn(table: "dbo.Reservas", name: "Funcion_Id", newName: "FuncionId");
            AddColumn("dbo.Reservas", "PeliculaId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Reservas", "FuncionId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Reservas", "FuncionId");
            AddForeignKey("dbo.Reservas", "FuncionId", "dbo.Funcions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "FuncionId", "dbo.Funcions");
            DropIndex("dbo.Reservas", new[] { "FuncionId" });
            AlterColumn("dbo.Reservas", "FuncionId", c => c.Byte());
            DropColumn("dbo.Reservas", "PeliculaId");
            RenameColumn(table: "dbo.Reservas", name: "FuncionId", newName: "Funcion_Id");
            CreateIndex("dbo.Reservas", "Funcion_Id");
            AddForeignKey("dbo.Reservas", "Funcion_Id", "dbo.Funcions", "Id");
        }
    }
}
