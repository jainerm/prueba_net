namespace paginamaestra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudades",
                c => new
                    {
                        IdCiudad = c.Int(nullable: false, identity: true),
                        NomCiudad = c.String(nullable: false, maxLength: 40),
                        NomImagen = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.IdCiudad);
            
            CreateTable(
                "dbo.Climas",
                c => new
                    {
                        IdClima = c.Int(nullable: false, identity: true),
                        IdCiudad = c.Int(nullable: false),
                        DiaSemana = c.Int(nullable: false),
                        Temperatura = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdClima);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Climas");
            DropTable("dbo.Ciudades");
        }
    }
}
