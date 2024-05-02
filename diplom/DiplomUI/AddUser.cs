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
using diplom.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class AddUser : Form
    {
        string id_user, status, name_usr;
        bool show_pass, show_confirm;
        
        public AddUser(string id_user, string status, string name_usr)
        {
            InitializeComponent();

            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;

            status_cB.Text = "Сотрудник";

            // скрыть пароль
            pwd_tB.UseSystemPasswordChar = true;
            confirm_tB.UseSystemPasswordChar = true;
            //
        }

        // Обработчик нажатия на кнопку "Назад"
        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        // Скрыть/показать пароли
        private void confirm_cB_Click(object sender, EventArgs e)
        {
            if (!show_confirm)
            {

                confirm_cB.Image = Resources.opened_eye;
                confirm_tB.UseSystemPasswordChar = false;
                show_confirm = true;
            }
            else
            {
                confirm_cB.Image = Resources.closed_eye;
                confirm_tB.UseSystemPasswordChar = true;
                show_confirm = false;
            }
        }

        private void pass_cB_Click(object sender, EventArgs e)
        {
            if (!show_pass)
            {
                pass_cB.Image = Resources.opened_eye;
                pwd_tB.UseSystemPasswordChar = false;
                show_pass = true;
            }
            else
            {
                pass_cB.Image = Resources.closed_eye;
                pwd_tB.UseSystemPasswordChar = true;
                show_pass = false;
            }
        }
        //

        // Проверка полей на отсутствие значений
        private void name_tB_TextChanged(object sender, EventArgs e)
        {
            if (name_tB.Text == "") { name_lbl.Visible = true; }
            else { name_lbl.Visible = false; }
        }

        private void phone_tB_TextChanged(object sender, EventArgs e)
        {
            if (phone_tB.Text != "") { phone_lbl.Visible = false; }
            else {  phone_lbl.Visible = true; }
        }

        private void email_tB_TextChanged(object sender, EventArgs e)
        {
            if (email_tB.Text == "") {  email_lbl.Visible = true; }
            else {  email_lbl.Visible = false; }
        }

        private void login_tB_TextChanged(object sender, EventArgs e)
        {
            if (login_tB.Text == "") {  login_lbl.Visible = true; }
            else { login_lbl.Visible = false; }
        }

        private void pwd_tB_TextChanged(object sender, EventArgs e)
        {
            if (pwd_tB.Text == "") {  pwd_lbl.Visible = true; }
            else {  pwd_lbl.Visible = false; }
        }

        private void confirm_tB_Leave(object sender, EventArgs e)
        {
            if (confirm_tB.Text != pwd_tB.Text)
            {
                confirm_tB.Text = "";
                confirm_lbl.Visible = true;
                MessageBox.Show("Пароли не совпадают", "Подтвердите пароль");
            }
            else { confirm_lbl.Visible = false; }
        }
        //

        // Обработчик нажатия на кнопку "Создать"
        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_tB.Text != "" & phone_tB.Text != "" & email_tB.Text != "" & login_tB.Text != "" & pwd_tB.Text != "" & confirm_tB.Text != "")
            {
                Trigger.Addlog("add", name_usr, name_tB.Text);
                UsersModel new_user = new UsersModel(name_tB.Text, status_cB.Text, phone_tB.Text, email_tB.Text + '@' + domain_cB.Text, login_tB.Text, pwd_tB.Text);
                new_user.Key = Encryption.GetKey();
                new_user.Iv = Encryption.GetVector();
                AddNewUser(new_user);

                GoBack();
            }
            else { MessageBox.Show("Пожалуйста, заполните все поля, отмеченные * ", "Внимание"); }
        }

       private void AddNewUser(UsersModel user)
       {
            DataManager.AddUser(user);
       }

        private void GoBack()
        {
            Users usr_frm = new Users(id_user, status, name_usr);
            usr_frm.Show();
            this.Close();
        }
    }
}
