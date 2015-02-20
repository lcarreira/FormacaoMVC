using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace From_WCF.EFMappings
{
    public class BookAuthors_Mapping : EntityTypeConfiguration<EntityModels.BookAuthors>
    {
        public BookAuthors_Mapping()
        {
            this.ToTable("BookAuthors");

            // Primary Key
            this.HasKey(t => t.rowNumber);
        }
    }
}