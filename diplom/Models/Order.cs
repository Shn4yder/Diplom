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
        public string Number { get; set; }
        public string Name { get; set; }
        public int Counter { get; set; }    
        public DateTime TimeStart { get; set; }
        public string Comment { get; set; } 
        public int IdUsr { get; set; }

        public Order() { }

        public Order(int id, string number, string name, int counter, DateTime timeStart, string comment, int idUsr)
        {
            Id = id;
            Name = name;
            Number = number;
            Counter = counter;
            TimeStart = timeStart;
            Comment = comment;
            IdUsr = idUsr;
        }   
    }
}
