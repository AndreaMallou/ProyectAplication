namespace ProyectAplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Constellation",
                c => new
                    {
                        IdConstellation = c.Int(nullable: false, identity: true),
                        Name_C = c.String(),
                        Hemisphere = c.String(),
                        Period = c.String(),
                        Name_S = c.String(),
                    })
                .PrimaryKey(t => t.IdConstellation);
            
            CreateTable(
                "dbo.Star",
                c => new
                    {
                        IdCStar = c.Int(nullable: false, identity: true),
                        Name_S = c.String(),
                        Tipo = c.String(),
                        IdConstellation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCStar);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Star");
            DropTable("dbo.Constellation");
        }
    }
}
