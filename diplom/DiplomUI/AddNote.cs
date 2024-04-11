using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diplom.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class AddNote : Form
    {
        string id_user, status, name_usr;
        public AddNote(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Notes note_frm = new Notes(id_user, status, name_usr);
            note_frm.Show();
            this.Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            NoteModel new_note = new NoteModel();

            new_note.Name = name_tB.Text;
            new_note.Phone = phone_tB.Text;
            new_note.Place = place_tB.Text;
            new_note.Comment = comment_tB.Text;
            new_note.Date_add = DateTime.Now.ToString();
            new_note.Id_user = Convert.ToInt16(id_user);

            AddNewNote(new_note);

            Notes note_frm = new Notes(id_user, status, name_usr);
            note_frm.Show();
            this.Close();
        }

        private void AddNewNote(NoteModel note)
        {
            DataManager.AddNote(note);
        }
    }
}
