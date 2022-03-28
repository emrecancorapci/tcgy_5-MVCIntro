using System.Collections.Generic;
using mvcIntro.Entities;

namespace mvcIntro.Business
{
    public class FakeFeaturedService : IFeaturedService
    {
        private int _count = 0;
        private readonly ICollection<Book> _featuredBooks;

        public FakeFeaturedService()
        {
            _featuredBooks = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "The Social Contract - Featured",
                    Author = "Jean-Jacques Rousseau",
                    Pages = 72,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/510D4zUwWsL._SX322_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Id = 2,
                    Name = "Two Treatises of Government - Featured",
                    Author = "John Locke",
                    Pages = 464,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/41aA6OWfzcL._SX316_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Id = 3,
                    Name = "The Prince",
                    Author = "Niccolo Machiavelli - Featured",
                    Pages = 184,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/41zVMmMPMQS._SX346_BO1,204,203,200_.jpg"
                }
            };
        }

        public ICollection<Book> GetFeaturedBook() => _featuredBooks;
        public int GetCount() => _count;
        public void AddCount() => _count++;
    }
}