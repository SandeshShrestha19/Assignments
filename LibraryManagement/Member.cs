using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public Member(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Borrow(Book book)
        {
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed {book.Title}.");
            }
            else
            {
                Console.WriteLine($"{book.Title} isn't available.");
            }
        }
        public void Return(Book book)
        {
            if(BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{Name} returned {book.Title}.");
            }
            else
            {
                Console.WriteLine($"{book.Title} isn't returned by {Name}.");
            }
        }
    }
}
