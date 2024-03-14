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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void order_MenuItem_Click(object sender, EventArgs e)
        {
            Orders ord_frm = new Orders();
            this.Hide();
            ord_frm.ShowDialog();
        }

        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_emp gds_ord = new Goods_emp();
            this.Hide();
            gds_ord.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddNote add_frm = new AddNote();
            add_frm.Show();
        }
    }
}
