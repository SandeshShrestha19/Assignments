using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();
        List<Transaction> transactions = new List<Transaction>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void RegisterMember(Member member)
        {
            members.Add(member);
        }

        public void BorrowBook(int memberId, int bookId)
        {
            var member = members.Find(member => member.MemberId == memberId);
            var book = books.Find(book => book.Id == bookId);
            if (!book.IsAvailable)
            {
                return;
            }
            book.IsAvailable = false;
            transactions.Add(new Transaction(transactions.Count + 1, member, book, "Borrow"));
        }
        public void ReturnBook(int memberId, int bookId)
        {
            var member = members.Find(m => m.MemberId == memberId);
            var book = books.Find(b => b.Id == bookId);
            if (book.IsAvailable)
            {
                return;
            }
            book.IsAvailable = true;
            transactions.Add(new Transaction(transactions.Count + 1, member, book, "Return"));
        }

        public void ShowBooks()
        {
            foreach (var book in books)
            {
                string bookAvailability = book.CheckBookAvailability();
                Console.WriteLine(bookAvailability);
            }
        }
        public void ShowTransactions()
        {
            foreach(var transaction in transactions)
            {
                string transactionRecord = transaction.ShowTransactionRecord();
                Console.WriteLine(transactionRecord);
            }
        }
    }
}
