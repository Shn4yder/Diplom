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
        List<GoodModel> goods = new List<GoodModel>();
        string id_order, id_user, status, name_usr;


        public EditOrdForm(string id_order, string id_user, string status, string name_usr)
        {
            InitializeComponent();
            this.id_order = id_order;
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
            GetOrder();
            order_timer.Start();
            goods = DataManager.LoadGoods();
            goods_GV.DataSource = goods;
            cart_GV.DataSource = DataManager.LoadCart(id_order);
            cart_amount_lbl.Text = AmountCart().ToString();
        }

        private void GetOrder()
        {
            order = DataManager.LoadOrder(id_order);

            name_tB.Text = order[0].Name.ToString();
            ppl_UpDown.Value = order[0].Counter;
            comment_tB.Text = order[0].Comment.ToString();
            numb_lbl.Text = numb_lbl.Text + order[0].Number.ToString(); 
            var time_duration = (DateTime.Now - Convert.ToDateTime(order[0].Time_start)).Duration();
            time_lbl.Text = ($"{time_duration.Hours} ч. {time_duration.Minutes} мин. {time_duration.Seconds} с.");
        }

        private void UpdateData()
        {
            OrderModel edit_order = new OrderModel();

            edit_order.Name = name_tB.Text;
            edit_order.Counter = Convert.ToInt16(ppl_UpDown.Value);
            edit_order.Comment = comment_tB.Text;

            DataManager.UpdateOrder(edit_order, id_order);  
        }

        private void order_timer_Tick(object sender, EventArgs e)
        {
            TimeSpan second = new TimeSpan(10000000);
            var time_duration = (DateTime.Now - Convert.ToDateTime(order[0].Time_start)).Duration();
            time_duration.Add(second);
            time_lbl.Text = ($"{time_duration.Hours} ч. {time_duration.Minutes} мин. {time_duration.Seconds} с.");
            double total_time = DataManager.LoadTarif() * (time_duration.Minutes + time_duration.Hours * 60) * Convert.ToDouble(ppl_UpDown.Value);
            if (time_checkB.Checked) { total_time = 0; }
            time_amount.Text = (total_time + AmountCart()).ToString();
        }

        private void goods_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CartModel cart = new CartModel();
            cart.Id_order = Convert.ToInt16(id_order);
            cart.Id_good = Convert.ToInt16(goods_GV.CurrentRow.Cells[0].Value.ToString());
            cart.Quantity = 1;

            DataManager.AddGoodInOrder(cart);
            cart_GV.DataSource = DataManager.LoadCart(id_order);
            cart_amount_lbl.Text = AmountCart().ToString();
        }

        private void cart_GV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = cart_GV.CurrentRow.Cells[0].Value.ToString();
            DataManager.DeleteGoodCart(id);
            cart_GV.DataSource = DataManager.LoadCart(id_order);
            cart_amount_lbl.Text = AmountCart().ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            Orders form = new Orders(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Orders form = new Orders(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

        private void add_pay_btn_Click(object sender, EventArgs e)
        {
            OrderPay pay = new OrderPay();

            pay.Date_pay = DateTime.Now;
            pay.Id_order = Convert.ToInt32(id_order);
            pay.Payment = pay_cB.Text;

            if (pay_cB.SelectedIndex != 2)
            {
                pay.Amount = Convert.ToDouble(time_amount.Text);
                DataManager.AddPay(pay);
            }
            else
            {

                pay.Payment = "безналичные";
                pay.Amount = Convert.ToDouble(nenal_tB.Text);
                DataManager.AddPay(pay);

                pay.Payment = "наличные";
                pay.Amount = Convert.ToDouble(nal_tB.Text);
                DataManager.AddPay(pay);
            }

            DataManager.DeleteOrder(id_order);

            this.Close();
            Orders form = new Orders(id_user, status, name_usr);
            form.Show();
        }

        private double AmountCart() 
        {
            double total = 0;
            foreach (DataGridViewRow row in cart_GV.Rows)
            {
                total += Convert.ToDouble(row.Cells[5].Value) * Convert.ToDouble(row.Cells[3].Value);
            }
            return total;
        }

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
    }
}
