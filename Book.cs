using System;
namespace BookShelf
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Book);
        }

        public bool Equals(Book other)
        {
            return other != null &&
                   Id == other.Id &&
                   ISBN == other.ISBN &&
                   Title == other.Title &&
                   Author == other.Author;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ISBN, Title, Author);
        }
    }


}
