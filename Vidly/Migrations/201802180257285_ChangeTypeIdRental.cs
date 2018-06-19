namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeIdRental : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Rentas");
            AlterColumn("dbo.Rentas", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Rentas", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Rentas");
            AlterColumn("dbo.Rentas", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Rentas", "Id");
        }
    }
}
