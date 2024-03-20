using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class UsersModel
    {
        public int Id_user { get; set; }
        public string FIO { get; set; }
        public string Status { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Theme { get; set; }


        public UsersModel() { }


        public UsersModel(int id_usr, string fIO, string status, string phone, string email, string login, string password, bool theme)
        {
            Id_user = id_usr;
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
