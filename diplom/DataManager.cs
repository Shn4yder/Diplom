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

        private static string LoadConnectionString(string id = "database")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
