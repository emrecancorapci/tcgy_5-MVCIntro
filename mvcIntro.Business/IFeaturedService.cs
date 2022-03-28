using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcIntro.Entities;

namespace mvcIntro.Business
{
    public interface IFeaturedService
    {
        ICollection<Book> GetFeaturedBook();
        int GetCount();
        void AddCount();
    }
}
