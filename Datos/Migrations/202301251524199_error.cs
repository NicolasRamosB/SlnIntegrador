namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class error : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Habitacion", "Estado", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Habitacion", "Estado", c => c.Boolean(nullable: false));
        }
    }
}
