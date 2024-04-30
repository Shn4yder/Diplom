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
        public byte[] Key { get; set; }
        public byte[] Iv { get; set; }

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

        public UsersModel(EncryptedUser encrypted)
        {
            this.Key = encrypted.Key;
            this.Iv = encrypted.Iv;

            this.Fio = Encryption.Decrypt(encrypted.Fio, Key, Iv);
            this.Status = Encryption.Decrypt(encrypted.Status, Key, Iv);
            this.Phone = Encryption.Decrypt(encrypted.Phone, Key, Iv);
            this.Email = Encryption.Decrypt(encrypted.Email, Key, Iv);
            this.Login = Encryption.Decrypt(encrypted.Login, Key, Iv);
            this.Password = Encryption.Decrypt(encrypted.Password, Key, Iv);
        }
    }
}
