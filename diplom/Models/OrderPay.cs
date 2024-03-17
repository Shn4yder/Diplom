using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class OrderPay
    {
        public int IdPay { get; set; }
        public double Amount { get; set; }  
        public string Payment { get; set; }
        public DateTime Date { get; set; }
        public int IdOrd { get; set; }

        public OrderPay() { }


        public OrderPay(int idPay, double amount, string payment, DateTime date, int idOrd)
        {
            IdPay = idPay;
            Amount = amount;
            Payment = payment;
            Date = date;
            IdOrd = idOrd;
        }
    }
}
