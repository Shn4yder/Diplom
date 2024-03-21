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
    public partial class Notes : Form
    {
        List<NoteModel> notes = new List<NoteModel>();  
        public Notes()
        {
            InitializeComponent();
            notes = DataManager.LoadNotes();
            note_GV.DataSource = notes; 
        }

        private void order_MenuItem_Click(object sender, EventArgs e)
        {
            Orders ord_frm = new Orders();
            this.Hide();
            ord_frm.ShowDialog();
        }

        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_adm gds_frm = new Goods_adm();
            this.Hide();
            gds_frm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddNote add_frm = new AddNote();
            add_frm.Show();
            this.Hide();
        }
    }
}
