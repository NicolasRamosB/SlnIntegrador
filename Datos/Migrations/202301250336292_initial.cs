namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroHistorialClinica = c.Int(nullable: false),
                        MedicoId = c.Int(nullable: false),
                        HabitacionId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Habitacion", t => t.HabitacionId, cascadeDelete: true)
                .ForeignKey("dbo.Medico", t => t.MedicoId, cascadeDelete: true)
                .Index(t => t.MedicoId)
                .Index(t => t.HabitacionId);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Especialidad = c.String(nullable: false, maxLength: 50, unicode: false),
                        Matricula = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medico");
            DropForeignKey("dbo.Pacientes", "HabitacionId", "dbo.Habitacion");
            DropIndex("dbo.Pacientes", new[] { "HabitacionId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropTable("dbo.Medico");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Habitacion");
        }
    }
}
