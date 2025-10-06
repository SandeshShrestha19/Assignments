using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public Member Member { get; set; }
        public Book Book { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } // Borrow or Return

        public Transaction(int id, Member member, Book book, string type)
        {
            TransactionId = id;
            Member = member;
            Book = book;
            Type = type;
            Date = DateTime.UtcNow;
        }

        public string ShowTransactionRecord()
        {
            return $"[{TransactionId}] {Type} | {Book.Name} | by {Member.Name} on {Date}";
        }
    }
}
