namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 255),
                        Nick = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Contrasena = c.String(nullable: false, maxLength: 255),
                        Telefono = c.Int(),
                        Tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
