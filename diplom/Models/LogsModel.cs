using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class LogsModel
    {
        public int Id_log { get; set; }
        public string Date_log { get; set; }
        public string Event { get; set; }
        public string Cause { get; set; }
        public string User {  get; set; }   
        public string System { get; set; }
        public byte[] Key { get; set; }
        public byte[] Iv { get; set; }

        public LogsModel() { }

        public LogsModel(EncrLogsModel log)
        {
            this.Key = log.Key;
            this.Iv = log.Iv;
            this.Id_log = log.Id_log;
            this.Date_log = Encryption.Decrypt(log.Date_log, Key, Iv);
            this.Event = Encryption.Decrypt(log.Event, Key, Iv);
            this.Cause = Encryption.Decrypt(log.Cause, Key, Iv);
            this.User = Encryption.Decrypt(log.User, Key, Iv);  
            this.System = Encryption.Decrypt(log.System, Key, Iv);
        }

        public LogsModel(string date_log, string event_log, string cause, string user, string system, byte[] key, byte[] iv)
        {
            Date_log = date_log;
            Event = event_log;
            Cause = cause;
            User = user;
            System = system;
            Key = key;
            Iv = iv;
        }
    }
}
