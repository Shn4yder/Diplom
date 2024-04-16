﻿using System;
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
    public partial class Notes : Form
    {

        string id_usr, status, name_usr;
        bool sidebarExpand;
        public Notes(string id_usr, string status, string name_usr)
        {
            InitializeComponent();
            note_GV.DataSource = DataManager.LoadNotes();
            this.id_usr = id_usr;
            this.status = status;
            this.name_usr = name_usr;

            //name_lbl.Text = $"Хорошего дня, {name_usr}!";
            CheckRole(status);
        }

        private void menu_timer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 100;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    menu_timer.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    menu_timer.Stop();

                }
            }
        }

        private void sidebar_btn_Click(object sender, EventArgs e)
        {
            menu_timer.Start();
        }

        private void items_btn_Click(object sender, EventArgs e)
        {
            Goods_adm gds_frm = new Goods_adm(id_usr, status, name_usr);
            this.Hide();
            gds_frm.Show();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            Orders ord_frm = new Orders(id_usr, status, name_usr);
            this.Hide();
            ord_frm.Show();
        }

        private void usr_btn_Click(object sender, EventArgs e)
        {
            Users frm = new Users(id_usr, status, name_usr);
            this.Hide();
            frm.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (status != "Администратор")
            {
                ReportManager report = new ReportManager(name_usr);

                var mail = MailManager.CreateMail("litvinastya7@mail.ru", $"Отчет по смене за {DateTime.Now.ToString("dd.MM.yyyy")}", $"{report.GetReport()}");
                mail.IsBodyHtml = true;

                MailManager.SendMail(mail);
            }
            this.Close(); 
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            AddNote add_frm = new AddNote(id_usr, status, name_usr);
            add_frm.Show();
            this.Hide();
        }

        private void note_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status == "Администратор")
            {
                string id = note_GV.CurrentRow.Cells[0].Value.ToString();

                EditNoteForm form = new EditNoteForm(id, id_usr, status, name_usr);
                this.Hide();
                form.Show();
            }
            else
            {
                if (note_GV.CurrentRow.Cells[7].Value.ToString() == id_usr)    // пренадлежит заметка пользователю?
                {
                    string id = note_GV.CurrentRow.Cells[0].Value.ToString();

                    EditNoteForm form = new EditNoteForm(id, id_usr, status, name_usr);
                    this.Hide();
                    form.Show();
                }
            }
            
        }

        private void CheckRole(string role)
        {
            if (role != "Администратор")
            {
                usr_btn.Visible = false;
                usr_btn.Enabled = false;
            }
            else
            {
                order_btn.Visible = false;
                order_btn.Enabled = false;
                exit_btn.Text = "Выйти";
            }
        }
    }
}
