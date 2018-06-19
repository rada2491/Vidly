namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataBase : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Users");
        }
        
        public override void Down()
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
    }
}
