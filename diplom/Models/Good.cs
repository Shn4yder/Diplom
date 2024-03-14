using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class Good
    {
        public int IdGood { get; set; }
        public string Name {  get; set; }
        public double Cost { get; set; }
        public string Img { get; set; } 

        
        public Good() { }


        public Good(int idGood, string name, double cost, string img)
        {
            IdGood = idGood;
            Name = name;
            Cost = cost;
            Img = img;
        }   
    }
}
