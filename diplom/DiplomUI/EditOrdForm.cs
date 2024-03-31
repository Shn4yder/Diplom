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

namespace diplom
{
    public partial class EditOrdForm : Form
    {
        List<OrderModel> order = new List<OrderModel>();
        List<GoodModel> goods = new List<GoodModel>();
        string id_order;
        public EditOrdForm(string id_order)
        {
            InitializeComponent();
            this.id_order = id_order;
            GetOrder();
            order_timer.Start();
            goods = DataManager.LoadGoods();
            goods_GV.DataSource = goods;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteOrder(id_order);

            Orders form = new Orders();
            form.Show();
            this.Close();
        }

        private void GetOrder()
        {
            order = DataManager.LoadOrder(id_order);

            name_tB.Text = order[0].Name.ToString();
            ppl_UpDown.Value = order[0].Counter;
            comment_tB.Text = order[0].Comment.ToString();
            numb_lbl.Text = numb_lbl.Text + order[0].Number.ToString(); 
            var time_duration = (DateTime.Now - Convert.ToDateTime(order[0].Time_start)).Duration();
            time_lbl.Text = ($"{time_duration.Days} дн. {time_duration.Minutes} мин. {time_duration.Seconds} с.");

        }

        private void UpdateData()
        {
          
            OrderModel edit_order = new OrderModel();

            edit_order.Name = name_tB.Text;
            edit_order.Counter = Convert.ToInt16(ppl_UpDown.Value);
            edit_order.Comment = comment_tB.Text;

            DataManager.UpdateOrder(edit_order, id_order);  
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            Orders form = new Orders();
            form.Show();
            this.Close();
        }

        private void order_timer_Tick(object sender, EventArgs e)
        {
            TimeSpan second = new TimeSpan(10000000);
            var time_duration = (DateTime.Now - Convert.ToDateTime(order[0].Time_start)).Duration();
            time_duration.Add(second);
            time_lbl.Text = ($"{time_duration.Days} дн. {time_duration.Minutes} мин. {time_duration.Seconds} с.");
        }

        private void goods_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CartModel cart = new CartModel();
            cart.Id_order = Convert.ToInt16(id_order);
            cart.Id_good = Convert.ToInt16(goods_GV.CurrentRow.Cells[0].Value.ToString());
            cart.Quantity = 1;

            DataManager.AddGoodInOrder(cart);
            cart_GV.DataSource = DataManager.LoadCart();
        }
    }
}
