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
            GoBack();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (name_tB.Text != "" & place_tB.Text != "" & comment_tB.Text != "")
            {
                UpdateData();
                GoBack();
            }
            else
            {
                MessageBox.Show("Невозможно сохранить пустую заметку", "Внимание");
            }
        }

        private void GetNote()
        {
            List<NoteModel> note = DataManager.LoadNote(id_note);

            name_tB.Text = note[0].Name.ToString();
            phone_tB.Text = note[0].Phone.ToString();
            place_tB.Text = note[0].Place.ToString();   
            comment_tB.Text = note[0].Comment.ToString();
        }

        private void UpdateData()
        {
            NoteModel edit_note = new NoteModel(name_tB.Text, phone_tB.Text, place_tB.Text, comment_tB.Text, DateTime.Now.ToString(), Convert.ToInt32(id_user));
            DataManager.UpdateNote(edit_note, id_note);
        }

        private void GoBack()
        {
            Notes form = new Notes(id_user, status, name_usr);
            form.Show();
            this.Close();
        }
    }
}
