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

        // Обработчик нажатия на кнопку "Назад"
        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        // Обработчик нажатия на кнопку "Создать"
        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_tB.Text != "" || phone_tB.Text != "" || place_tB.Text != "" || comment_tB.Text != "")
            {
                NoteModel new_note = new NoteModel(name_tB.Text, phone_tB.Text, place_tB.Text, comment_tB.Text, DateTime.Now.ToString(), Convert.ToInt16(id_user));
                AddNewNote(new_note);

                GoBack();
            }
            else
            {
                MessageBox.Show("Невозможно создать пустую заметку", "Внимание");
            }
        }

        private void AddNewNote(NoteModel note)
        {
            DataManager.AddNote(note);
        }

        // Возврат на родительскую форму
        private void GoBack()
        {
            Notes note_frm = new Notes(id_user, status, name_usr);
            note_frm.Show();
            this.Close();
        }
    }
}
