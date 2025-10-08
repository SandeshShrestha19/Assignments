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
        public TypeOfTransfer TransferType { get; set; } // Borrow or Return

        public Transaction(int id, Member member, Book book, TypeOfTransfer typeOfTransfer )
        {
            TransactionId = id;
            Member = member;
            Book = book;
            TransferType = typeOfTransfer;
            Date = DateTime.UtcNow;
        }

        public string ShowTransactionRecord()
        {
            return $"[{TransactionId}] {TransferType} | {Book.Name} | by {Member.Name} on {Date}";
        }
    }
}
