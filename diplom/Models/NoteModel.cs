using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class NoteModel
    {
        public int Id_note { get; set; } 
        public string Name { get; set; }    
        public string Phone {  get; set; }
        public string Place { get; set; }
        public string Comment { get; set; }
        public string Date_add { get; set; }
        public string Fio { get; set; }
        public int Id_user { get; set; }    

        public NoteModel() { }

        public NoteModel(string name, string phone, string place, string comment, string date_add, int id_user)
        {
            Name = name;
            Phone = phone;
            Place = place;
            Comment = comment;
            Date_add = date_add;
            Id_user = id_user;
        }
    }
}
