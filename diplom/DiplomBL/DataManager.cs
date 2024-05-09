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
using System.Drawing;
using diplom.Properties;
using System.Windows.Forms;
namespace diplom
{
    internal class DataManager
    {
        // Загрузка, вставка, удаление, изменение данных пользователей
        public static List<UsersModel> LoadUsers()
        {
            List<UsersModel> users = new List<UsersModel>();
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<EncryptedUser>("select * from Users", new DynamicParameters());
                foreach (EncryptedUser enc_usr in res.ToList())
                {
                    users.Add(new UsersModel(enc_usr));
                }
                return users;
            }
        }

        public static void AddUser(UsersModel user)
        {
            EncryptedUser encrypted = new EncryptedUser(user);
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Users(fio, status, phone, email, login, password, key, iv) values(@Fio, @Status, @Phone, @Email, @Login, @Password, @Key, @Iv)", encrypted);
            }
        } 

        public static void DeleteUser(string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("delete from Users where id_user=" + id);
            }
        }

        public static UsersModel LoadUser(string id)    // получение данных о конкретном пользователе
        {
            List<UsersModel> users = new List<UsersModel>();
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<EncryptedUser>("select * from Users where id_user=" + id, new DynamicParameters());
                foreach (EncryptedUser enc_usr in res.ToList())
                {
                    users.Add(new UsersModel(enc_usr));
                }
                return users[0];
            }
        }

        public static void UpdateUser(UsersModel user, string id)
        {
            UsersModel enc_usr = LoadUser(id);
            user.Key = enc_usr.Key; 
            user.Iv = enc_usr.Iv;

            EncryptedUser enc = new EncryptedUser(user);    
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE Users SET fio= @Fio,status=@Status, phone=@Phone, email=@Email, login=@Login, password=@Password WHERE id_user = " + id, enc);
            }
        }

        public static UsersModel Search(string login, string pass)
        {
            List<UsersModel> users = DataManager.LoadUsers();
            foreach (UsersModel user in users)
            {
                if (user.Login == login & user.Login == login)
                {
                    return user;
                }
            }
            return null;
        }


        // Загрузка, вставка, удаление, изменение данных заметок
        public static List<NoteModel> LoadNotes() 
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                List<NoteModel> valid_notes = new List<NoteModel>();    
                var res = con.Query<NoteModel>("select id_note, name, Notes.phone, place, comment, date_add, fio, Notes.id_user, key, iv from Notes, Users where Notes.id_user = Users.id_user", new DynamicParameters());
                foreach (NoteModel note in res.ToList())
                {
                    note.Decr_fio = Encryption.Decrypt(note.Fio, note.Key, note.Iv);
                    valid_notes.Add(note);
                }
                return valid_notes;
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

        public static List<GoodModel> LoadGoods(string order_mode)
        {
            
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<GoodModel>("select * from Goods where id_good != 1 " + order_mode, new DynamicParameters());
                foreach (GoodModel good in res.ToList())
                {
                    try
                    {
                        Image img = Image.FromFile(good.Img);   // получение изображения по пути из БД
                        Bitmap resized_image = new Bitmap(img, new Size(130, 100));    // изменение размеров полученного изображения
                        good.image = resized_image;
                    }
                    catch
                    {
                        good.image = Resources.default_photo;
                    }
                    
                }
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

        public static List<GoodModel> LoadGood(string id)    // получение данных о конкретном товаре
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<GoodModel>("select * from Goods where id_good=" + id, new DynamicParameters());
                foreach (GoodModel good in res.ToList())
                {
                    try
                    {
                        Image img = Image.FromFile(good.Img);   // получение изображения по пути из БД
                        //Bitmap resized_image = new Bitmap(img, new Size(130, 100));    // изменение размеров полученного изображения
                        good.image = img;
                    }
                    catch 
                    {
                        good.image = Resources.default_photo;
                    }

                }
                return res.ToList();
            }
        }

        public static void UpdateGood(GoodModel good, string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE Goods SET img=@Img, name=@Name, cost=@Cost WHERE id_good = " + id, good);
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

        public static List<OrderModel> LoadOrder(string id)    // получение данных о конкретном заказе
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<OrderModel>("select * from Orders where id_order=" + id, new DynamicParameters());
                return res.ToList();
            }
        }

        public static void UpdateOrder(OrderModel order, string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE Orders SET name=@Name, counter=@Counter, comment=@Comment WHERE id_order = " + id, order);
            }
        }


        // Вставка, удаление данных корзины заказа
        public static void AddNewGoodInOrder(CartModel cart)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into Cart(id_order, id_good, quantity) values(@Id_order, @Id_good, @Quantity)", cart);
            }
        }

        public static List<CartModel> LoadCart(string id)   
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<CartModel>("select id_cart, id_order, Cart.id_good AS id_good, quantity, Goods.name AS name, Goods.cost AS cost from Cart, Goods where Cart.id_good = Goods.id_good AND id_order=" + id, new DynamicParameters());
                return res.ToList();
            }
        }

        public static void DeleteGoodCart(string id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("delete from Cart where id_cart=" + id);
            }
        }

        public static void ChangeQuantityInOrder(int new_quantity, string id_cart)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute($"update Cart set quantity = {new_quantity} where id_cart = " + id_cart);
            }
        }


        public static double LoadTarif()    // получение стоимости тарифа
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<GoodModel>("select * from Goods where id_good = 1", new DynamicParameters());
                List<GoodModel> good = res.ToList();

                double tarif = good[0].Cost;
                return tarif;   
            }
        }


        //Добавление, получение данных о оплате
        public static void AddPay(OrderPay pay)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into OrderPay(amount, payment, date_pay, counter, id_order) values(@Amount, @Payment, @Date_pay, @Counter, @Id_order)", pay);
            }
        }
        public static List<OrderPay> GetDatedPay(DateTime date)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<OrderPay>("select * from OrderPay where date_pay like '" + date.ToString("yyyy-MM-dd") + "%'", new DynamicParameters());
                return res.ToList();
            }
        }

        //Получение и удаление данных из электронного журнала безопасности
        public static List<LogsModel> LoadLogs()
        {
            List<LogsModel> logs = new List<LogsModel>();
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var res = con.Query<EncrLogsModel>("select * from SecurityLogs ", new DynamicParameters());
                foreach (EncrLogsModel enc_log in res.ToList())
                {
                    logs.Add(new LogsModel(enc_log));
                }
                return logs;
            }
        }

        public static void DeleteLogs()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("delete from SecurityLogs");
            }
        }

        private static string LoadConnectionString(string id = "database")    // строка подключения
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
