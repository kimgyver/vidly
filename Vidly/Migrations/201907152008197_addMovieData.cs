namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");
            Sql("SET IDENTITY_INSERT Genres Off ");

            Sql("SET IDENTITY_INSERT Movies ON ");
            Sql("Insert into movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values (1, 'Hangover', 5, '20091106', '20190701', 5)");
            Sql("Insert into movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values (2, 'Die Hard', 1, '19880801', '20190702', 6)");
            Sql("Insert into movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values (3, 'The Terminator', 1, '19931206', '20190703', 7)");
            Sql("Insert into movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values (4, 'The Story', 3, '20091106', '20190704', 4)");
            Sql("Insert into movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values (5, 'Titanic', 4, '20000106', '20190705', 3)");
            Sql("SET IDENTITY_INSERT Movies Off ");
        }

        public override void Down()
        {
        }
    }
}
