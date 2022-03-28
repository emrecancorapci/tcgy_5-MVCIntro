using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcIntro.Entities;

namespace mvcIntro.Business
{
    public interface IBookService
    {
        ICollection<Book> GetBooks();
        int GetCount();
        void AddCount();
    }
}
