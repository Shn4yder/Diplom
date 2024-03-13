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
