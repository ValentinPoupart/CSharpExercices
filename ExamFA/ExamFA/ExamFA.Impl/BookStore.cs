using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamFA.Impl
{
    public class BookStore
    {
        private readonly List<Book> books = new List<Book>
        {
            new Book
            {
                Title = "Ta 2ème vie commence quand tu comprends que tu n'en as qu'une",
                Author = "Raphaëlle Giordano",
                Editor = "Pocket",
                PageCount = 256,
                ReleaseDate = new DateTime(2017, 06, 01)
            },
            new Book
            {
                Title = "Le premier jour du reste de ma vie",
                Author = "Virginie Grimaldi",
                Editor = "Le livre de poche",
                PageCount = 162,
                ReleaseDate = new DateTime(2016, 05, 04)
            },
            new Book
            {
                Title = "Chère mamie",
                Author = "Virginie Grimaldi",
                Editor = "Le livre de poche",
                PageCount = 142,
                ReleaseDate = new DateTime(2018, 10, 31)
            },
            new Book
            {
                Title = "Le jour où j'ai appris à vivre",
                Author = "Laurent Gounelle",
                Editor = "Pocket",
                PageCount = 288,
                ReleaseDate = new DateTime(2016, 04, 07)
            },
            new Book
            {
                Title = "Rompre",
                Author = "Yann Moix",
                Editor = "Grasset",
                PageCount = 128,
                ReleaseDate = new DateTime(2019, 01, 02)
            }

        };

        public IEnumerable<Book> GetAllBooks()
        {
            return books.Select(x => x);
        }

        public IEnumerable<Book> GetAllBooksByDate()
        {
            return books.OrderBy(x => x.ReleaseDate);
        }

        public IEnumerable<Book> GetAllBooksWrittenByAuthorLastName(string authorLastName)
        {
            return books.Where(x => x.Author.Contains(authorLastName)); 
        }

        public IEnumerable<Book> GetAllBooksWrittenByAuthorLastNameAfterYear(string authorLastName)
        {
            return books.Where(x => x.Author.Contains(authorLastName) && x.ReleaseDate.Year >= 2017);
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PageCount { get; set; }
    }
}
