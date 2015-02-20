namespace From_WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "ISBN", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Author", c => c.String());
            AlterColumn("dbo.Books", "ISBN", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
        }
    }
}
