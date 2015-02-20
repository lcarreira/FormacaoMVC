using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    [DataContract]
    public class BookAuthors
    {
        [DataMember]
        public Int64 rowNumber { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string AuthorName { get; set; }
    }
}
