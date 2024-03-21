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
                con.Execute("insert into Users(fio, status, phone, email, login, password) values(@FIO, @Status, @Phone, @Email, @Login, @Password)", user);
            }
        } 

        public static void DeleteUser(string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("delete from Users where id_user=" + id);
            }
        }

        public static List<UsersModel> LoadUser(string id)    // получение данных о конкретном пользователе
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<UsersModel>("select * from Users where id_user=" + id, new DynamicParameters());
                return res.ToList();
            }
        }

        public static void UpdateUser(UsersModel user, string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE Users SET fio= @FIO,status=@Status, phone=@Phone, email=@Email, login=@Login, password=@Password WHERE id_user = " + id, user);
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

        public static void DeleteNote(string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("delete from Notes where id_note=" + id);
            }
        }

        public static List<NoteModel> LoadNote(string id)    // получение данных о конкретной заметке
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<NoteModel>("select * from Notes where id_note=" + id, new DynamicParameters());
                return res.ToList();
            }
        }

        public static void UpdateNote(NoteModel note, string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE Notes SET name=@Name, phone=@Phone, place=@Place, comment=@Comment, date_add=@Date_add WHERE id_note = " + id, note);
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

        public static void DeleteGood(string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("delete from Goods where id_good=" + id);
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
        public static void DeleteOrder(string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("delete from Orders where id_order=" + id);
            }
        }



        private static string LoadConnectionString(string id = "database")    // строка подключения
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
