namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medico", "IdMedico", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medico", "IdMedico");
        }
    }
}
