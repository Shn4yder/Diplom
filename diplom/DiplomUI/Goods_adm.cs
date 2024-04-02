using diplom.Models;
using diplom.Properties;
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
    public partial class Goods_adm : Form
    {
        List<GoodModel> goods = new List<GoodModel>();
        string id_user, status, name_usr;
        public Goods_adm(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            goods = DataManager.LoadGoods();
            goods_GV.DataSource = goods;
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
        }

        private void user_MenuItem_Click(object sender, EventArgs e)
        {
            Users usr_frm = new Users(id_user, status, name_usr);
            this.Hide();
            usr_frm.Show();
        }

        private void note_MenuItem_Click(object sender, EventArgs e)
        {
            Notes note_frm = new Notes(id_user, status, name_usr);
            this.Hide();
            note_frm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddGood add_frm = new AddGood(id_user, status, name_usr);
            this.Hide();
            add_frm.Show();
        }

        private void goods_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = goods_GV.CurrentRow.Cells[0].Value.ToString();

            EditGoodForm form = new EditGoodForm(id, id_user, status, name_usr);
            this.Hide();
            form.Show();
        }
    }
}
