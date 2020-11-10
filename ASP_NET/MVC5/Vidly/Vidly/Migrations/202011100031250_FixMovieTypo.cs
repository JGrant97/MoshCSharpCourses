namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovieTypo : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "MoveGenre_Id", newName: "MovieGenre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_MoveGenre_Id", newName: "IX_MovieGenre_Id");
            AddColumn("dbo.Movies", "MovieGenreID", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "MovreGenreID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovreGenreID", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "MovieGenreID");
            RenameIndex(table: "dbo.Movies", name: "IX_MovieGenre_Id", newName: "IX_MoveGenre_Id");
            RenameColumn(table: "dbo.Movies", name: "MovieGenre_Id", newName: "MoveGenre_Id");
        }
    }
}
