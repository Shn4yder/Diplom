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
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

            NoteModel new_note = new NoteModel();

            new_note.Name = name_tB.Text;
            new_note.Phone = phone_tB.Text;
            new_note.Place = place_tB.Text;
            new_note.Comment = comment_tB.Text;
            new_note.Date_add = DateTime.Now.ToString();
            new_note.Id_user = 2;

            AddNewNote(new_note);

            Notes note_frm = new Notes();
            note_frm.Show();
            this.Close();
        }

        private void AddNewNote(NoteModel note)
        {
            DataManager.AddNote(note);
        }
    }
}
