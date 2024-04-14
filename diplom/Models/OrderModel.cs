using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class OrderModel
    {
        public int Id_order { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int Counter { get; set; }    
        public string Time_start { get; set; }
        public string Comment { get; set; } 
        public int Id_user { get; set; }

        public OrderModel() { }

        public OrderModel(string number, string name, int counter, string time_start, string comment, int id_user)
        {
            Number = number;
            Name = name;
            Counter = counter;
            Time_start = time_start;
            Comment = comment;
            Id_user = id_user;
        }
    }
}
