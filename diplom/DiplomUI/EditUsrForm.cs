using diplom.Models;
using diplom.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class EditUsrForm : Form
    {
        string id_edit_user, id_user, sts, name_usr;
        bool show_pass;
        public EditUsrForm(string id_edit_user, string id_user, string sts, string name_usr)
        {
            InitializeComponent();

            this.id_edit_user = id_edit_user;
            this.id_user = id_user;
            this.sts = sts;
            this.name_usr = name_usr;

            pass_tB.UseSystemPasswordChar = true;   // скрыть пароль
            GetUser();
        }

        // Обработчик события нажатия на кнопку "Сохранить"
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (name_tB.Text != "" & phone_tB.Text != "" & email_tB.Text != "" & login_tB.Text != "" & pass_tB.Text != "")
            {
                UpdateData();
                GoBack();
            }
            else { MessageBox.Show("Пожалуйста, заполните все поля, отмеченные * ", "Внимание"); }
        }

        // Обработчик события нажатия на кнопку "Назад"
        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();   
        }

        // Скрыть/показать пароль
        private void pass_cB_Click(object sender, EventArgs e)
        {
            if (!show_pass)
            {
                pass_cB.Image = Resources.opened_eye;
                pass_tB.UseSystemPasswordChar = false;
                show_pass = true;
            }
            else
            {
                pass_cB.Image = Resources.closed_eye;
                pass_tB.UseSystemPasswordChar = true;
                show_pass = false;
            }
        }

        // Обработчик события нажатия на кнопку "Удалить"
        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Действительно удалить выбранного пользователя? Будут удалены все связанные с ним события - заметки, заказы, журнал безопасности. Отменить действие будет невозможно", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Trigger.Addlog("delete", name_usr, name_tB.Text);
                DataManager.DeleteUser(id_edit_user);
                GoBack();
            } 
        }

        // Проверка полей на отсутствие значений
        private void name_tB_TextChanged(object sender, EventArgs e)
        {
            if (name_tB.Text == "") { name_lbl.Visible = true; }
            else { name_lbl.Visible = false; }
        }

        private void phone_tB_TextChanged(object sender, EventArgs e)
        {
            if (phone_tB.Text != "") { phone_lbl.Visible = false; }
            else { phone_lbl.Visible = true; }
        }

        private void email_tB_TextChanged(object sender, EventArgs e)
        {
            if (email_tB.Text == "" || !isValid(email_tB.Text)) { email_lbl.Visible = true; email_tB.Text = "";}
            else { email_lbl.Visible = false; }
        }

        private void login_tB_TextChanged(object sender, EventArgs e)
        {
            if (login_tB.Text == "") { login_lbl.Visible = true; }
            else { login_lbl.Visible = false; }
        }

        private void pass_tB_TextChanged(object sender, EventArgs e)
        {
            if (pass_tB.Text == "") { pwd_lbl.Visible = true; }
            else { pwd_lbl.Visible = false; }
        }
        //

        // Получение данных о пользователе
        private void GetUser()
        {
            UsersModel user = DataManager.LoadUser(id_edit_user);

            name_tB.Text = user.Fio;
            status_cB.Text = user.Status;
            phone_tB.Text = user.Phone;
            email_tB.Text = user.Email;
            login_tB.Text = user.Login;
            pass_tB.Text = user.Password;
        }

        private void UpdateData()
        {
            Trigger.Addlog("update", name_usr, name_tB.Text);
            UsersModel edit_user = new UsersModel(name_tB.Text, status_cB.Text, phone_tB.Text, email_tB.Text, login_tB.Text, pass_tB.Text);
            DataManager.UpdateUser(edit_user, id_edit_user);
        }
        
        // Возврат на родительскую форму
        private void GoBack()
        {
            Users users = new Users(id_user, sts, name_usr);
            users.Show();
            this.Close();
        }

        bool isValid(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }
    }
}