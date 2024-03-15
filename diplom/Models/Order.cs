using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int Counter { get; set; }    
        public DateTime TimeStart { get; set; }
        public string Comment { get; set; } 

        public Order() { }

        public Order(int id, string name, string number, int counter, DateTime timeStart, string comment)
        {
            Id = id;
            Name = name;
            Number = number;
            Counter = counter;
            TimeStart = timeStart;
            Comment = comment;
        }   
    }
}
