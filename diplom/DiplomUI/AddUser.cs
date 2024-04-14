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

            pwd_tB.UseSystemPasswordChar = true;
            confirm_tB.UseSystemPasswordChar = true;

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

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

        private void create_btn_Click(object sender, EventArgs e)
        {
            UsersModel new_user = new UsersModel(name_tB.Text, status_cB.Text, phone_tB.Text, email_tB.Text + '@' + domain_cB.Text, login_tB.Text, pwd_tB.Text);
            AddNewUser(new_user);

            GoBack();
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
