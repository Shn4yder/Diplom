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

    }
}
