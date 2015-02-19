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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class BibliotecaService : IBibliotecaService
    {

        public List<EntityModels.Book> GetBooks()
        {
            List<Book> returnVal;

            try
            {
                using(var context = new BibliotecaDB())
                {
                    returnVal = context.Books.ToList();
                }
            }
            catch(Exception ex)
            {
                returnVal = new List<Book>();
            }

            return returnVal;
        }

        public EntityModels.Book InsertBook(EntityModels.Book b)
        {
            Book retVal;

            try
            {
                using(var context = new BibliotecaDB())
                {
                    retVal = context.Books.Add(b);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                retVal = new Book();
            }

            return retVal;
        }
    }
}
