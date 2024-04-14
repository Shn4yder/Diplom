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
        public string Fio { get; set; }
        public string Status { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UsersModel() { }

        public UsersModel(string fio, string status, string phone, string email, string login, string password)
        {
            Fio = fio;
            Status = status;
            Phone = phone;
            Email = email;
            Login = login;
            Password = password;
        }
    }
}
