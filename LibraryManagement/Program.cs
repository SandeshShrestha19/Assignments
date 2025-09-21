using System;
using LibraryManagement;

class Program
{
    static void Main(string[] args)
    {
        Book bookOne = new Book(0001, "The Rising Sun", "Kirat Hamal", true);
        Book bookTwo = new Book(0002, "Atomic Habits", "James Clear", true);
        Book bookThree = new Book(0003, "The Alchemists", "Paulo Coelho", false);

        Member memberOne = new Member(1, "Ram Shrestha");
        Member memberTwo = new Member(2, "Hari Maharjan");

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
