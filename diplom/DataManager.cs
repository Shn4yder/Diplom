using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using diplom.Models;

namespace diplom
{
    internal class DataManager
    {
        public static List<UsersModel> LoadUsers()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<UsersModel>("select * from Users", new DynamicParameters());
                return res.ToList();
            }
        }

        public static List<NoteModel> LoadNotes() 
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<NoteModel>("select id_note, name, Notes.phone, place, comment, date_add, fio from Notes, Users where Notes.id_user = Users.id_user", new DynamicParameters());
                return res.ToList();
            }
        }

        public static List<GoodModel> LoadGoods()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<GoodModel>("select * from Goods", new DynamicParameters());
                return res.ToList();
            }
        }

        public static List<OrderModel> LoadOrders()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<OrderModel>("select * from Orders", new DynamicParameters());
                return res.ToList();
            }
        }

        private static string LoadConnectionString(string id = "database")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
