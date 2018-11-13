using System;
using System.Collections.Generic;

namespace BookShelf
{
    public interface IBookShelfService
    {
        IEnumerable<Book> GetBooks();
        void Update(Book book);
        void Remove(int bookId);
        void Add(Book book);
    }
}
