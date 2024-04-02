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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class Notes : Form
    {
        List<NoteModel> notes = new List<NoteModel>();
        string id_usr, status, name_usr;
        public Notes(string id_usr, string status, string name_usr)
        {
            InitializeComponent();
            notes = DataManager.LoadNotes();
            note_GV.DataSource = notes;
            this.id_usr = id_usr;
            this.status = status;
            this.name_usr = name_usr;
        }

        private void order_MenuItem_Click(object sender, EventArgs e)
        {
            Orders ord_frm = new Orders(id_usr, status, name_usr);
            this.Hide();
            ord_frm.ShowDialog();
        }

        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_adm gds_frm = new Goods_adm(id_usr, status, name_usr);
            this.Hide();
            gds_frm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddNote add_frm = new AddNote(id_usr, status, name_usr);
            add_frm.Show();
            this.Hide();
        }

        private void note_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = note_GV.CurrentRow.Cells[0].Value.ToString();

            EditNoteForm form = new EditNoteForm(id, id_usr, status, name_usr);
            this.Hide();
            form.Show();
        }
    }
}
