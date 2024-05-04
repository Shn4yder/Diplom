using diplom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class EditOrdForm : Form
    {
        List<OrderModel> order = new List<OrderModel>();
        string id_order, id_user, status, name_usr;


        public EditOrdForm(string id_order, string id_user, string status, string name_usr)
        {
            InitializeComponent();

            this.id_order = id_order;
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;

            GetOrder();
            order_timer.Start();    // запуск таймера, отсчитывает пройденное с момента создания заказа время

            // заполнение таблиц
            goods_GV.DataSource = DataManager.LoadGoods("ORDER BY id_good ASC");  
            cart_GV.DataSource = DataManager.LoadCart(id_order);
            //

            cart_amount_lbl.Text = AmountCart().ToString();
            pay_cB.Text = "безналичные";
        }

        // Получение данных о заказе
        private void GetOrder()
        {
            order = DataManager.LoadOrder(id_order);

            name_tB.Text = order[0].Name.ToString();
            ppl_UpDown.Value = order[0].Counter;
            comment_tB.Text = order[0].Comment.ToString();
            numb_lbl.Text = numb_lbl.Text + order[0].Number.ToString(); 

            // Расчет стоимости времени
            var time_duration = (DateTime.Now - Convert.ToDateTime(order[0].Time_start)).Duration();
            time_lbl.Text = ($"{time_duration.Hours} ч. {time_duration.Minutes} мин. {time_duration.Seconds} с.");
            //
        }

        private void UpdateData()
        {
            OrderModel edit_order = new OrderModel(numb_lbl.Text, name_tB.Text, Convert.ToInt16(ppl_UpDown.Value), order[0].Time_start, comment_tB.Text, Convert.ToInt16(id_user));
            DataManager.UpdateOrder(edit_order, id_order);  
        }

        // Расчет стоимости корзины
        private double AmountCart()
        {
            double total = 0;
            foreach (DataGridViewRow row in cart_GV.Rows)
            {
                total += Convert.ToDouble(row.Cells[5].Value) * Convert.ToDouble(row.Cells[3].Value);
            }
            return total;
        }

        // Обработчик Таймера (вызов каждую секунду)
        private void order_timer_Tick(object sender, EventArgs e)
        {
            TimeSpan second = new TimeSpan(10000000);   // экв. 1 секунде

            // Расчет стоимости времени
            var time_duration = (DateTime.Now - Convert.ToDateTime(order[0].Time_start)).Duration();
            time_duration.Add(second);
            time_lbl.Text = ($"{time_duration.Hours} ч. {time_duration.Minutes} мин. {time_duration.Seconds} с.");
            //
            // Расчет полной стоимости заказа (учитыая/не учитывая время)
            double total_time = DataManager.LoadTarif() * (time_duration.Minutes + time_duration.Hours * 60) * Convert.ToDouble(ppl_UpDown.Value);
            if (time_checkB.Checked) { total_time = 0; }
            time_amount.Text = (total_time + AmountCart()).ToString();
            //
        }

        // Обработчик двойного нажатия на товар в таблице с товарами = добавление товара в корзину
        private void goods_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CartModel cart = new CartModel(Convert.ToInt16(id_order), Convert.ToInt16(goods_GV.CurrentRow.Cells[0].Value.ToString()), 1);
            DataManager.AddGoodInOrder(cart);
            cart_GV.DataSource = DataManager.LoadCart(id_order);
            cart_amount_lbl.Text = AmountCart().ToString();
        }

        // Обработчик двойного нажатия на товар в корзине = удалить товар из корзины
        private void cart_GV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataManager.DeleteGoodCart(cart_GV.CurrentRow.Cells[0].Value.ToString());
            cart_GV.DataSource = DataManager.LoadCart(id_order);
            cart_amount_lbl.Text = AmountCart().ToString();
        }

        // Обработчик нажатия на кнопку "Сохранить"
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (name_tB.Text != "")
            {
                UpdateData();
                GoBack();
            }
            else { MessageBox.Show("Пожалуйста, заполните все поля, отмеченные * ", "Внимание"); }
        }

        // Обработчик нажатия на кнопку "Назад"
        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        // Обработчик нажатия на кнопку "Завершить"
        private void add_pay_btn_Click(object sender, EventArgs e)
        {
            if (pay_cB.SelectedIndex != 2)
            {
                OrderPay pay = new OrderPay(Convert.ToDouble(time_amount.Text), pay_cB.Text, DateTime.Now, Convert.ToInt16(ppl_UpDown.Value) ,Convert.ToInt16(id_order));
                DataManager.AddPay(pay);
            }
            else    // если выбранный способ опалты - "смешанная", вводится сумма безналичными и наличными
            {
                OrderPay pay_cashless = new OrderPay(Convert.ToDouble(nenal_tB.Text), "безналичные", DateTime.Now, Convert.ToInt16(ppl_UpDown.Value),Convert.ToInt16(id_order));
                DataManager.AddPay(pay_cashless);

                OrderPay pay_cash = new OrderPay(Convert.ToDouble(nal_tB.Text), "наличные", DateTime.Now, 0, Convert.ToInt16(id_order));
                DataManager.AddPay(pay_cash);
            }
            DataManager.DeleteOrder(id_order);

            GoBack();
        }

        // Поверка поля на отсутствие значений
        private void name_tB_TextChanged(object sender, EventArgs e)
        {
            if (name_tB.Text == "") { name_lbl.Visible = true; }
            else { name_lbl.Visible = false; }
        }

        // Показать textbox если выбранный способ оплаты - "смешанная"
        private void pay_cB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pay_cB.SelectedIndex == 2)
            {
                panel2.Visible = true; panel4.Visible = true;
                nenal_tB.Visible = true;
                nal_tB.Visible = true;
            }
            else
            {
                nal_tB.Visible = false;
                nenal_tB.Visible = false;
            }
        }

        // Возврат на родительскую форму
        private void GoBack()
        {
            this.Close();
            Orders form = new Orders(id_user, status, name_usr);
            form.Show();
        }
    }
}
