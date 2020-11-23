namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.s", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.s", "Name", c => c.String());
        }
    }
}