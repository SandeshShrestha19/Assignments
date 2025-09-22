using System;
using LibraryManagement;

class Program
{
    static void Main(string[] args)
    {
        var bookOne = new Book(0001, "The Rising Sun", "Kirat Hamal", true);
        var bookTwo = new Book(0002, "Atomic Habits", "James Clear", true);
        var bookThree = new Book(0003, "The Alchemists", "Paulo Coelho", false);

        var memberOne = new Member(1, "Ram Shrestha");
        var memberTwo = new Member(2, "Hari Maharjan");

        //bookOne.ReturnBooks();

        memberOne.Borrow(bookThree);

        bookThree.ReturnBook();

        memberOne.Borrow(bookThree);

        memberOne.Borrow(bookTwo);
        memberTwo.Borrow(bookTwo);

        //memberTwo.Return(bookOne);

        Console.ReadLine();
    }
}
