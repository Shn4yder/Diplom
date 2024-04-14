using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class CartModel
    {
        public int Id_cart { get; set; }
        public int Id_order {  get; set; }
        public int Id_good { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }    
        public double Cost { get; set; }    

        public CartModel() { }

        public CartModel(int id_order, int id_good, int quantity)
        {
            Id_order = id_order;
            Id_good = id_good;
            Quantity = quantity;
        }
    }
}
