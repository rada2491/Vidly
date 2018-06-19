namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2MembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET NAME = 'Quarterly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes SET NAME = 'Annual' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
