using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class OrderPay
    {
        public int Id_pay { get; set; }
        public double Amount { get; set; }  
        public string Payment { get; set; }
        public DateTime Date_pay { get; set; }
        public int Counter { get; set; }    
        public int Id_order { get; set; }

        public OrderPay() { }

        public OrderPay(double amount, string payment, DateTime date_pay, int counter, int id_order)
        {
            Amount = amount;
            Payment = payment;
            Date_pay = date_pay;
            Counter = counter;  
            Id_order = id_order;
        }
    }
}
