using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace From_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBibliotecaService
    {
        [OperationContract]
        List<Book> GetBooks();

        [OperationContract]
        Book InsertBook(Book b);
    }
}
