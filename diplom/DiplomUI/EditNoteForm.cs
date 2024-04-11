using diplom.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class EditNoteForm : Form
    {
        string id_note, id_user, status, name_usr;
        List<NoteModel> note = new List<NoteModel>();
        public EditNoteForm(string id_note, string id_user, string status, string name_usr)
        {
            InitializeComponent();
            this.id_note = id_note;
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
              
            GetNote();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteNote(id_note);

            Notes form = new Notes(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Notes form = new Notes(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            Notes form = new Notes(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

        private void GetNote()
        {
            note = DataManager.LoadNote(id_note);

            name_tB.Text = note[0].Name.ToString();
            phone_tB.Text = note[0].Phone.ToString();
            place_tB.Text = note[0].Place.ToString();   
            comment_tB.Text = note[0].Comment.ToString();
        }

        private void UpdateData()
        {
            NoteModel edit_note = new NoteModel();

            edit_note.Name = name_tB.Text;
            edit_note.Phone = phone_tB.Text;
            edit_note.Place = place_tB.Text;
            edit_note.Comment = comment_tB.Text;
            edit_note.Date_add = DateTime.Now.ToString();

            DataManager.UpdateNote(edit_note, id_note);
        }
    }
}
