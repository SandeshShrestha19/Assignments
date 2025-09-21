using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string title, string author, bool isAvailable)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }

        public void BorrowBook()
        {
            if(IsAvailable)
            {
                IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"{Title} is not available.");
            }
        }
        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
            }
            else
            {
                Console.WriteLine($"{Title} wasn't borrowed.");
            }
        }
    }
}
