using diplom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class EditUsrForm : Form
    {
        List<UsersModel> users = new List<UsersModel>();
        string id_user;
        public EditUsrForm(string id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
            GetUser();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteUser(id_user);

            Users users = new Users();
            users.Show();
            this.Close();
        }

        private void GetUser()
        {
            users = DataManager.LoadUser(id_user);

            name_tB.Text = users[0].FIO.ToString();
            status_cB.Text = users[0].Status.ToString(); 
            phone_tB.Text = users[0].Phone.ToString();
            email_tB.Text = users[0].Email.ToString();
            login_tB.Text = users[0].Login.ToString();
            pass_tB.Text = users[0].Password.ToString();    
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            Users users = new Users();
            users.Show();
            this.Close();
        }

        private void UpdateData()
        {
            UsersModel edit_user = new UsersModel();

            edit_user.FIO = name_tB.Text;
            edit_user.Status = status_cB.Text;
            edit_user.Phone = phone_tB.Text;
            edit_user.Email = email_tB.Text;
            edit_user.Login = login_tB.Text;    
            edit_user.Password = pass_tB.Text;

            DataManager.UpdateUser(edit_user, id_user);
        }
    }
}
