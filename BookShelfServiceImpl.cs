using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace BookShelf
{
    public class BookShelfServiceImpl : IBookShelfService
    {
        //public List<Book> bookShelf;
        public List<Book> bookShelf = new List<Book> { };
        private static BookShelfServiceImpl instance;

        private BookShelfServiceImpl()
        {

        }

        //singleton instance for bookshelf
        public static BookShelfServiceImpl GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookShelfServiceImpl();
                }
                return instance;
            }


        }

        //Add one new book to the bookshelf if it is not already exists
        void IBookShelfService.Add(Book book)
        {
            if (!bookShelf.Exists((Book obj) => obj.Id == book.Id))
                bookShelf.Add(book);
        }

        //Get list of all books from the bookshelf as an ienumerable read-only
        IEnumerable<Book> IBookShelfService.GetBooks()
        {
            return bookShelf.AsEnumerable();
        }

        //Remove one book by its Id from the bookshelf
        void IBookShelfService.Remove(int bookToRemoveId)
        {
            Book bookToRemove = bookShelf.Find((Book obj) => obj.Id == bookToRemoveId);
            if (bookToRemove != null)
            {
                bookShelf.Remove(bookToRemove);
            }
        }

        //Update a book in the bookshelf
        void IBookShelfService.Update(Book newBook)
        {
            Book oldBook = bookShelf.Find((Book obj) => obj.Id == newBook.Id);
            int oldBookIndex = bookShelf.IndexOf(oldBook);
            //check if the old book exist
            if (oldBookIndex != -1)
            {
                bookShelf[oldBookIndex] = newBook;
            }
        }

    }
}
