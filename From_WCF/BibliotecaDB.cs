namespace From_WCF
{
    using EntityModels;
    using From_WCF.EFMappings;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BibliotecaDB : DbContext
    {
        // Your context has been configured to use a 'BibliotecaDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'From_WCF.BibliotecaDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BibliotecaDB' 
        // connection string in the application configuration file.
        static BibliotecaDB()
        {
            Database.SetInitializer<BibliotecaDB>(null);
        }

        public BibliotecaDB()
            : base("name=BibliotecaDB")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }


        public DbSet<BookAuthors> BookAuthors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookAuthors_Mapping());
        }
    }
}