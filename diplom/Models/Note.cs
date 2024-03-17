using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class Note
    {
        public int IdNote { get; set; } 
        public string Name { get; set; }    
        public string Phone {  get; set; }
        public string Place { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int IdUsr { get; set; }


        public Note() { }


        public Note(int idNote, string name, string phone, string place, string comment, DateTime date,  int idUsr)
        {
            IdNote = idNote;
            Name = name;
            Phone = phone;
            Place = place;
            Comment = comment;
            Date = date;
            IdUsr = idUsr;
        }
    }
}
