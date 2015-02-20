namespace From_WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databaseauthors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Nationality = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AuthorBooks",
                c => new
                    {
                        Author_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Author_Id, t.Book_Id })
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Author_Id)
                .Index(t => t.Book_Id);
            
            DropColumn("dbo.Books", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Author", c => c.String(nullable: false));
            DropForeignKey("dbo.AuthorBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "Author_Id", "dbo.Authors");
            DropIndex("dbo.AuthorBooks", new[] { "Book_Id" });
            DropIndex("dbo.AuthorBooks", new[] { "Author_Id" });
            DropTable("dbo.AuthorBooks");
            DropTable("dbo.Authors");
        }
    }
}
