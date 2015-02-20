namespace From_WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class View_Book_Authors : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE VIEW BookAuthors AS SELECT b.Id,
	                                                b.Title,
	                                                AuthorName = a.Name 
                                            FROM Books b
                                            LEFT JOIN AuthorBooks ab on ab.Book_Id = b.Id
                                            LEFT JOIN Authors a ON a.Id = ab.Author_Id");
        }
        
        public override void Down()
        {
            Sql("DROP VIEW BookAuthors");
        }
    }
}
