using System;
using LibraryManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        var library = new Library();

        library.AddBook(new Book(1, "The Rising Sun", "Kirat Hamal"));
        library.AddBook(new Book(2, "Atomic Habits", "James Clear"));
        library.AddBook(new Book(3, "The Alchemist", "Paulo Coelho"));

        var student = new StudentMember(1001, "Priya Subedi");
        var teacher = new TeacherMember(1002, "Khemey Mahato");

        library.RegisterMember(student);
        library.RegisterMember(teacher);

        library.BorrowBook(1001, 1);
        library.BorrowBook(1002, 2);
        library.ReturnBook(1001, 1);

        Console.WriteLine();

        Console.WriteLine("----| Books in Library | ----");
        library.ShowBooks();

        Console.WriteLine("\n----| Transaction Records |----");
        library.ShowTransactions();

        Console.ReadLine();

    }
}
