using System;
using System.Collections.Generic;
using mvcIntro.Entities;

namespace mvcIntro.Business
{
    public class FakeBookService : IBookService
    {
        private int _count = 0;
        private readonly List<Book> _books;

        public FakeBookService()
        {
            _books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "The Social Contract",
                    Author = "Jean-Jacques Rousseau",
                    Pages = 72,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/510D4zUwWsL._SX322_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Id = 2,
                    Name = "Two Treatises of Government",
                    Author = "John Locke",
                    Pages = 464,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/41aA6OWfzcL._SX316_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Id = 3,
                    Name = "The Prince",
                    Author = "Niccolo Machiavelli",
                    Pages = 184,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/41zVMmMPMQS._SX346_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Id = 4,
                    Name = "The Social Contract - 2",
                    Author = "Jean-Jacques Rousseau",
                    Pages = 72,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/510D4zUwWsL._SX322_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Id = 5,
                    Name = "Two Treatises of Government - 2",
                    Author = "John Locke",
                    Pages = 464,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/41aA6OWfzcL._SX316_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Id = 6,
                    Name = "The Prince - 3",
                    Author = "Niccolo Machiavelli",
                    Pages = 184,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/41zVMmMPMQS._SX346_BO1,204,203,200_.jpg"
                }
            };
        }

        public ICollection<Book> GetBooks() => _books;
        public int GetCount() => _count;
        public void AddCount() => _count++;
    }
}
