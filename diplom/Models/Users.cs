using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class Users
    {
        public int IdUsr { get; set; } 
        public string Status { get; set; }
        public string Phone { get; set; }
        public string  FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Theme { get; set; }


        public Users() { }


        public Users(int id_usr, string status, string phone, string fIO, string login, string password, string email, bool theme)
        {
            IdUsr = id_usr;
            Status = status;
            Phone = phone;
            FIO = fIO;
            Login = login;
            Password = password;
            Email = email;
            Theme = theme;
        }
    }
}
