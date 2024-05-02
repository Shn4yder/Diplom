using diplom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;

namespace diplom
{
    internal class Trigger
    {
        public static void Addlog(string @event, string user_name, string new_or_deleted_user = "", string system = "Art Coworking")
        {
            string event_log = "";
            string cause = "";

            if (@event == "delete")
            {
                event_log = $"Уничтожение общедоступных ПДн пользователя {new_or_deleted_user} (в т.ч. логина и пароля) путем удаления сведений из базы данных.";
                cause = "Пользователь исключен из штата сотрудников";
            }
            else if ( @event == "add")
            {
                event_log = $"Добавлен новый пользователь {new_or_deleted_user}. В обработке находятся общедоступные ПДн (ФИО, телефон, эл. почта, должность), логин и пароль.";
                cause = "В штат поступил новый сотрудник";
            }
            else if (@event == "enter") 
            {
                event_log = "Вход в систему";
                cause = " - ";
            }
            else if (@event == "exit")
            {
                event_log = "Выход из системы";
                cause = " - ";
            }
            else if (@event == "update")
            {
                event_log = $"Изменены данные пользователя {new_or_deleted_user}";
                cause = "Пользователь исключен из штата сотрудников";
            }

            LogsModel log = new LogsModel(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), event_log, cause, user_name, system, Encryption.GetKey(), Encryption.GetVector());
            EncrLogsModel encrypted_log = new EncrLogsModel(log);

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into SecurityLogs(date_log, event, cause, user, system, key, iv) values(@Date_log, @Event, @Cause, @User, @System, @Key, @Iv)", encrypted_log);
            }
        }

        private static string LoadConnectionString(string id = "database")    // строка подключения
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
