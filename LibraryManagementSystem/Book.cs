using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Author { get; set; }

        public bool IsAvailable { get; set; }

        public Book(int id, string name, string author)
        {
            this.Id = id;
            this.Name = name;
            this.Author = author;
            IsAvailable = true;
        }

        public string CheckBookAvailability()
        {
            return $"[{Id}] {Name} by {Author} - {(IsAvailable ? "Available" : "Not Available")}";
        }

    }
}
