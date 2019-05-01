namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MdSalas1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salas", "Nombre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Salas", "Nombre");
        }
    }
}
