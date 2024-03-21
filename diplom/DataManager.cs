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
        // Загрузка, вставка, удаление, изменение данных пользователей
        public static List<UsersModel> LoadUsers()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<UsersModel>("select * from Users", new DynamicParameters());
                return res.ToList();
            }
        }

        public static void AddUser(UsersModel user)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Users(fio, status, phone, email, login, password, theme) values(@FIO, @Status, @Phone, @Email, @Login, @Password, @Theme)", user);
            }
        }

        // Загрузка, вставка, удаление, изменение данных заметок
        public static List<NoteModel> LoadNotes() 
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<NoteModel>("select id_note, name, Notes.phone, place, comment, date_add, fio, Notes.id_user from Notes, Users where Notes.id_user = Users.id_user", new DynamicParameters());
                return res.ToList();
            }
        }

        public static void AddNote(NoteModel note)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Notes(name, phone, place, comment, date_add, id_user) values(@Name, @Phone, @Place, @Comment, @Date_add, @Id_user)", note);
            }
        }

        // Загрузка, вставка, удаление, изменение данных товаров
        public static List<GoodModel> LoadGoods()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<GoodModel>("select * from Goods", new DynamicParameters());
                return res.ToList();
            }
        }

        public static void AddGood(GoodModel good)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Goods(img, name, cost) values(@Img, @Name, @Cost)", good);
            }
        }

        // Загрузка, вставка, удаление, изменение данных заказов
        public static List<OrderModel> LoadOrders()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<OrderModel>("select * from Orders", new DynamicParameters());
                return res.ToList();
            }
        }

        public static void AddOrder(OrderModel order)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Orders(number, name, counter, time_start, comment, id_user) values(@Number, @Name, @Counter, @Time_start, @Comment, @Id_user)", order);
            }
        }



        private static string LoadConnectionString(string id = "database")    // строка подключения
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
