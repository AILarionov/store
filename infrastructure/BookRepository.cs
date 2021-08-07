using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
      {
        new Book(1,"ISBN 123-233-230 1", "D. Knuth", "Art of Programming"),
        new Book(2, "ISBN 123-233-230 2", "M. Fowler", "Refrectoring"),
        new Book(3, "ISBN 123-233-230 3", "B. Kernighan", "C Programming Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn.Contains(isbn)).ToArray();
        }

        public Book[] GetAllByTitleorAuthor(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
