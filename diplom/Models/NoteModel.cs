using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class NoteModel
    {
        public int IdNote { get; set; } 
        public string Name { get; set; }    
        public string Phone {  get; set; }
        public string Place { get; set; }
        public string Comment { get; set; }
        public DateTime Date_add { get; set; }
        public string UserName { get; set; }


        public NoteModel() { }


        public NoteModel(int idNote, string name, string phone, string place, string comment, DateTime date,  string username)
        {
            IdNote = idNote;
            Name = name;
            Phone = phone;
            Place = place;
            Comment = comment;
            Date_add = date;
            UserName = username;
        }
    }
}
