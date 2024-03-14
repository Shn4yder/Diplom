using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class Order
    {
        public int IdOrd { get; set; }
        public double Amount { get; set; }  
        public string Payment { get; set; }
        public DateTime Date { get; set; }
        public int IdUsr { get; set; }

        public Order() { }


        public Order(int idOrd, double amount, string payment, DateTime date, int idUsr)
        {
            IdOrd = idOrd;
            Amount = amount;
            Payment = payment;
            Date = date;
            IdUsr = idUsr;
        }
    }
}
