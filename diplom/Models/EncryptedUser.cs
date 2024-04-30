using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class EncryptedUser
    {
        public int Id_user { get; set; }
        public byte[] Fio { get; set; }
        public byte[] Status { get; set; }
        public byte[] Phone { get; set; }
        public byte[] Email { get; set; }
        public byte[] Login { get; set; }
        public byte[] Password { get; set; }
        public byte[] Key { get; set; }
        public byte[] Iv { get; set; }

        public EncryptedUser() { }

        public EncryptedUser(UsersModel user)
        {
            this.Key = user.Key;
            this.Iv = user.Iv;
            this.Fio = Encryption.Encrypt(user.Fio, Key, Iv);
            this.Status = Encryption.Encrypt(user.Status, Key, Iv);
            this.Phone = Encryption.Encrypt(user.Phone, Key, Iv);
            this.Email = Encryption.Encrypt(user.Email, Key, Iv);
            this.Login = Encryption.Encrypt(user.Login, Key, Iv);
            this.Password = Encryption.Encrypt(user.Password, Key, Iv);
        }
    }
}
