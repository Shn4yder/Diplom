using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class EncrLogsModel
    {
        public int Id_log { get; set; }
        public byte[] Date_log { get; set; }
        public byte[] Event { get; set; }
        public byte[] Cause { get; set; }
        public byte[] System { get; set; }
        public byte[] User { get; set; }
        public byte[] Key { get; set; }
        public byte[] Iv { get; set; }

        public EncrLogsModel() { }

        public EncrLogsModel(LogsModel log)
        {
            this.Key = log.Key;
            this.Iv = log.Iv;
            this.Id_log = log.Id_log;
            this.Date_log = Encryption.Encrypt(log.Date_log, Key, Iv);
            this.Event = Encryption.Encrypt(log.Event, Key, Iv);
            this.Cause = Encryption.Encrypt(log.Cause, Key, Iv);
            this.System = Encryption.Encrypt(log.System, Key, Iv);
            this.User = Encryption.Encrypt(log.User, Key, Iv);
        }
    }
}
