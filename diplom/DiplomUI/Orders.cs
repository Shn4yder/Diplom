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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            orders_GV.Rows.Add(4);
            string[] newrow = { "1", "2", "3", "4", "5", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", };
            orders_GV.Rows.Add(newrow);
        }

        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_emp good_frm = new Goods_emp();
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
        }
    }
}
