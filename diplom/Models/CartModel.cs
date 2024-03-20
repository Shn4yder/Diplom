 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class CartModel
    {
        public int IdCrt { get; set; }
        public int IdOrd {  get; set; }
        public int IdGd { get; set; }
        public int Quantity { get; set; }

        public CartModel() { }

        public CartModel(int idCrt, int idOrd, int idGd, int quantity)
        {
            IdCrt = idCrt;
            IdOrd = idOrd;
            IdGd = idGd;
            Quantity = quantity;
        }
    }
}
