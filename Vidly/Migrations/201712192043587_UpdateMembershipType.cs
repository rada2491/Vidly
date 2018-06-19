namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET NAME = 'Pay as You Go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes SET NAME = 'Monthly' WHERE ID = 2");
        }
        
        public override void Down()
        {
        }
    }
}
