﻿using diplom.Models;
using diplom.Properties;
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
        string id_edit_user, id_user, sts, name_usr;
        bool show_pass;
        public EditUsrForm(string id_edit_user, string id_user, string sts, string name_usr)
        {
            InitializeComponent();
            this.id_edit_user = id_edit_user;
            this.id_user = id_user;
            this.sts = sts;
            this.name_usr = name_usr;

            pass_tB.UseSystemPasswordChar = true;
            GetUser();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            Users users = new Users(id_user, sts, name_usr);
            users.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Users users = new Users(id_user, sts, name_usr);
            users.Show();
            this.Close();
        }

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

        private void del_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteUser(id_edit_user);

            Users users = new Users(id_user, sts, name_usr);
            users.Show();
            this.Close();
        }

        private void GetUser()
        {
            List<UsersModel> users = DataManager.LoadUser(id_edit_user);

            name_tB.Text = users[0].Fio.ToString();
            status_cB.Text = users[0].Status.ToString();
            phone_tB.Text = users[0].Phone.ToString();
            email_tB.Text = users[0].Email.ToString();
            login_tB.Text = users[0].Login.ToString();
            pass_tB.Text = users[0].Password.ToString();
        }

        private void UpdateData()
        {
            UsersModel edit_user = new UsersModel();

            edit_user.Fio = name_tB.Text;
            edit_user.Status = status_cB.Text;
            edit_user.Phone = phone_tB.Text;
            edit_user.Email = email_tB.Text;
            edit_user.Login = login_tB.Text;
            edit_user.Password = pass_tB.Text;

            DataManager.UpdateUser(edit_user, id_edit_user);
        }
    }
}