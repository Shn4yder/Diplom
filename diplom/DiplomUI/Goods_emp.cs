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
    public partial class Goods_emp : Form
    {
        public Goods_emp()
        {
            InitializeComponent();
        }

        private void order_MenuItem_Click(object sender, EventArgs e)
        {
            Orders ord_frm = new Orders();
            this.Hide();
            ord_frm.Show();
        }

        private void note_MenuItem_Click(object sender, EventArgs e)
        {
            Notes note_frm = new Notes();
            this.Hide();
            note_frm.Show();
        }
    }
}
