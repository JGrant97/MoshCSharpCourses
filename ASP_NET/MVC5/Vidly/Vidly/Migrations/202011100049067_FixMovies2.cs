namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovies2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MoveGenre_Id", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieGenreID", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "MoveGenre_Id");
        }
    }
}
