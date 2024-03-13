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
    public partial class Goods_adm : Form
    {
        public Goods_adm()
        {
            InitializeComponent();
        }

        private void user_MenuItem_Click(object sender, EventArgs e)
        {
            Users usr_frm = new Users();
            this.Hide();
            usr_frm.Show();
        }

        private void note_MenuItem_Click(object sender, EventArgs e)
        {
            Notes note_frm = new Notes();
            this.Hide();
            note_frm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddGood add_frm = new AddGood();
            add_frm.Show();
        }
    }
}
