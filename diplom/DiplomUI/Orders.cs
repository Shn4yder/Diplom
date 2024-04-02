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
        string id_user, status, name_usr;
        public Orders(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            orders = DataManager.LoadOrders();
            orders_GV.DataSource = orders;
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;  
        }

        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_adm good_frm = new Goods_adm(id_user, status, name_usr);
            this.Hide();
            good_frm.Show();
        }

        private void note_MenuItem_Click(object sender, EventArgs e)
        {
            Notes note_frm = new Notes(id_user, status, name_usr);
            this.Hide();
            note_frm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddOrder add_form = new AddOrder(id_user, status, name_usr);
            add_form.Show();
            this.Hide();
        }

        private void orders_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = orders_GV.CurrentRow.Cells[0].Value.ToString();

            EditOrdForm edit_frm = new EditOrdForm(id, id_user, status, name_usr);
            edit_frm.Show();
            this.Hide();
        }
    }
}
