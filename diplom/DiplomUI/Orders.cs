using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diplom.Models;

namespace diplom
{
    public partial class Orders : Form
    {
        List<OrderModel> orders = new List<OrderModel>();   
        public Orders()
        {
            InitializeComponent();
            orders = DataManager.LoadOrders();
            orders_GV.DataSource = orders;

        }

        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_adm good_frm = new Goods_adm();
            this.Hide();
            good_frm.Show();
        }

        private void note_MenuItem_Click(object sender, EventArgs e)
        {
            Notes note_frm = new Notes();
            this.Hide();
            note_frm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddOrder add_form = new AddOrder();
            add_form.Show();
            this.Hide();
        }

        private void orders_GV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
