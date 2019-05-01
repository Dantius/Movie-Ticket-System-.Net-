namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearReservasConfirmadas2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReservasConfirmadas", "asiento1", c => c.Int(nullable: false));
            AlterColumn("dbo.ReservasConfirmadas", "asiento2", c => c.Int(nullable: false));
            AlterColumn("dbo.ReservasConfirmadas", "asiento3", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReservasConfirmadas", "asiento3", c => c.Byte(nullable: false));
            AlterColumn("dbo.ReservasConfirmadas", "asiento2", c => c.Byte(nullable: false));
            AlterColumn("dbo.ReservasConfirmadas", "asiento1", c => c.Byte(nullable: false));
        }
    }
}
