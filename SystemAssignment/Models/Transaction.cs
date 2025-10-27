using System;
using System.Threading.Tasks;
using SystemAssignment.Constants;

namespace SystemAssignment.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public TransactionType TypeOfTransaction { get; set; }
        public decimal Amount { get; set;}
        public DateTime DateTime { get; set; }

    }
}
