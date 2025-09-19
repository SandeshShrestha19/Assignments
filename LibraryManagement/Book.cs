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

        public void BorrowBooks()
        {
            if(IsAvailable)
            {
                Console.WriteLine($"{Title} has been borrowed!");
            }
            else
            {
                Console.WriteLine($"{Title} is not available.");
            }
        }
        public void ReturnBooks()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"{Title} has been returned.");
            }
            else
            {
                Console.WriteLine($"{Title} wasn't borrowed.");
            }
        }
    }
}
