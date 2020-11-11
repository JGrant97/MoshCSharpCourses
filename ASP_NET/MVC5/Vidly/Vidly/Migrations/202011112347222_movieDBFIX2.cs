namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieDBFIX2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "MovieGenres_Id" });
            AlterColumn("dbo.Movies", "MovieGenres_Id", c => c.Byte());
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "MovieGenres_Id" });
            AlterColumn("dbo.Movies", "MovieGenres_Id", c => c.Byte());
        }
    }
}