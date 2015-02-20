using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    [DataContract(IsReference = true)]
    public class Book
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage="Campo Obrigatório!")]
        public string Title { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string ISBN { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Range(0, 2099, ErrorMessage="Ano Inválido!")]
        public int Year { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public decimal Price { get; set; }

        [DataMember]
        public virtual ICollection<Author> Authors { get; set; }
    }
}
