namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarSalas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Salas", "asiento1", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento2", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento3", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento4", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento5", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento6", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento7", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento8", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento9", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento10", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento11", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento12", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento13", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento14", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento15", c => c.Boolean());
            AlterColumn("dbo.Salas", "asiento16", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Salas", "asiento16", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento15", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento14", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento13", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento12", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento11", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento10", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento9", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento8", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento7", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento6", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento5", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento4", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento3", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento2", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Salas", "asiento1", c => c.Boolean(nullable: false));
        }
    }
}
