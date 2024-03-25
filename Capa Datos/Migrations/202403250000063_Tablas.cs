namespace Capa_Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 75),
                        Apellidos = c.String(nullable: false, maxLength: 75),
                        FechaIngreso = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Peliculas",
                c => new
                    {
                        PeliculaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 75),
                        Genero = c.String(nullable: false, maxLength: 30),
                        Autores = c.String(nullable: false, maxLength: 75),
                        Existencia = c.Int(nullable: false),
                        PrecioRenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PeliculaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Peliculas");
            DropTable("dbo.Clientes");
        }
    }
}
