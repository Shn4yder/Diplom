using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace diplom.Models
{
    internal class GoodModel
    {
        public int Id_good { get; set; }
        public string Img { get; set; }
        public string Name {  get; set; }
        public double Cost { get; set; }
        public Image image { get; set; }

        public GoodModel() { }
 
    }
}
