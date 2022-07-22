using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceFinanceApp.Models
{
    public class Mandate
    {
        [Key]
        public int ID { get; set; }
        public int MandateType_FK { get; set; }
        public DateTime TransactionDate { get; set; }
        public string LoanReference { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string BankCode { get; set; }
        public string ConsentUrl { get; set; }
        public int ActiveFlag { get; set; }
        public int IsVisible { get; set; }
        public DateTime DateMOdified { get; set; }
    }
}
