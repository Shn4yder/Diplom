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
    public partial class AddUser : Form
    {
        string id_user, status, name_usr;
        public AddUser(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            UsersModel new_user = new UsersModel();

            new_user.Fio = name_tB.Text;
            new_user.Status = status_cB.Text;   
            new_user.Phone = phone_tB.Text;
            new_user.Email = email_tB.Text;
            new_user.Login = login_tB.Text;
            new_user.Password = pwd_tB.Text;

            AddNewUser(new_user);

            Users usr_frm = new Users(id_user, status, name_usr);
            usr_frm.Show();
            this.Close();
        }

       private void AddNewUser(UsersModel user)
       {
            DataManager.AddUser(user);
       }
    }
}
