namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificarReservasParaIncluirusuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReservasConfirmadas", "usuarioMail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReservasConfirmadas", "usuarioMail");
        }
    }
}
