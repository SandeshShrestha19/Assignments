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
            if (!book.IsAvailable)
            {
                return;
            }
            BorrowedBooks.Add(book);
            //book.IsAvailable = false;
            book.BorrowBook();
            Console.WriteLine($"{Name} borrowed {book.Title}.");
        }
        public void Return(Book book)
        {
            if (!BorrowedBooks.Contains(book))
            {
                return;
            }
            BorrowedBooks.Remove(book);
            book.ReturnBook();
            Console.WriteLine($"{Name} returned {book.Title}.");
            
        }
    }
}
