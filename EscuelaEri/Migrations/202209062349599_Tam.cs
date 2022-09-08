namespace EscuelaEri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ApellidoP = c.String(),
                        ApellidoM = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grupos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Carrera = c.String(),
                        Cuatrimestre = c.Int(nullable: false),
                        Grupo = c.Int(nullable: false),
                        alumnos_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumnos", t => t.alumnos_Id)
                .Index(t => t.alumnos_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Grupos", "alumnos_Id", "dbo.Alumnos");
            DropIndex("dbo.Grupos", new[] { "alumnos_Id" });
            DropTable("dbo.Grupos");
            DropTable("dbo.Alumnos");
        }
    }
}
