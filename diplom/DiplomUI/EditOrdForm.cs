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
        string id_order;
        public EditOrdForm(string id_order)
        {
            InitializeComponent();
            this.id_order = id_order;
            GetOrder();
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
    }
}
