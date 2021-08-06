using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
      {
        new Book(1,"ISBN 12323-23231", "D. Knuth", "Art of Programming"),
        new Book(2, "ISBN 12323-23232", "M. Fowler", "Refrectoring"),
        new Book(3, "ISBN 12323-23233", "B. Kernighan", "C Programming Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            throw new NotImplementedException();
        }

        public Book[] GetAllByTitleorAuthor(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
