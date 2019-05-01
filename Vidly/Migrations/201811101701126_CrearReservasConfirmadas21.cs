namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearReservasConfirmadas21 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ReservasConfirmadas");
            AlterColumn("dbo.ReservasConfirmadas", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ReservasConfirmadas", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ReservasConfirmadas");
            AlterColumn("dbo.ReservasConfirmadas", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.ReservasConfirmadas", "Id");
        }
    }
}
