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
    public partial class EditUsrForm : Form
    {
        string id_user;
        List<UsersModel> user = new List<UsersModel>();

        public EditUsrForm(string id)
        {
            InitializeComponent();
            id_user = id;
            GetUser(id_user);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteUser(id_user);

            Users usr_from = new Users();   
            this.Close();
            usr_from.Show();
        }

        private void GetUser(string id)
        {
            user = DataManager.LoadUser(id_user);

            name_tB.Text = user[0].FIO.ToString();
            status_cB.Text = user[0].Status.ToString();
            phone_tB.Text = user[0].Phone.ToString();
            email_tB.Text= user[0].Email.ToString();
            login_tB.Text = user[0].Login.ToString();   
            pass_tB.Text = user[0].Password.ToString(); 
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            UsersModel edit_user = new UsersModel();

            edit_user.FIO = name_tB.Text;
            edit_user.Status = status_cB.Text;
            edit_user.Phone = phone_tB.Text;
            edit_user.Email = email_tB.Text;
            edit_user.Login = login_tB.Text;
            edit_user.Password = pass_tB.Text;

            EditUser(edit_user);

            Users usr_frm = new Users();
            usr_frm.Show();
            this.Close();
        }

        private void EditUser(UsersModel user)
        {
            DataManager.UpdateUser(user, id_user);
        }
    }
}
