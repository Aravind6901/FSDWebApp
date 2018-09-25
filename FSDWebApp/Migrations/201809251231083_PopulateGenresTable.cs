namespace FSDWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'ROCK')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'SOFT')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'ITEM')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
