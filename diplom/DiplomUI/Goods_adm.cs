using diplom.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using diplom.Controls;


namespace diplom
{
    public partial class Goods_adm : Form
    {
        string id_user, status, name_usr;
        bool sidebarExpand;

        public Goods_adm(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            goods_GV.DataSource = DataManager.LoadGoods();
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;

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

        private void note_btn_Click(object sender, EventArgs e)
        {
            Notes note_frm = new Notes(id_user, status, name_usr);
            this.Hide();
            note_frm.Show();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            Orders form = new Orders(id_user, status, name_usr);
            this.Hide();
            form.Show();
        }

        private void usr_btn_Click(object sender, EventArgs e)
        {
            Users usr_frm = new Users(id_user, status, name_usr);
            this.Hide();
            usr_frm.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (status != "Администратор")
            {
                ReportManager report = new ReportManager(name_usr);

                var mail = MailManager.CreateMail("litvinastya7@mail.ru", "test sub", $"{report.GetReport()}");
                mail.IsBodyHtml = true;

                MailManager.SendMail(mail);
            }
            this.Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            AddGood add_frm = new AddGood(id_user, status, name_usr);
            this.Hide();
            add_frm.Show();
        }

        private void goods_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (status == "Администратор")
            {
                string id = goods_GV.CurrentRow.Cells[0].Value.ToString();

                EditGoodForm form = new EditGoodForm(id, id_user, status, name_usr);
                this.Hide();
                form.Show();
            }
            
        }

        private void CheckRole(string role)
        {
            if (role != "Администратор")
            {
                create_btn.Visible = false;
                create_btn.Enabled = false;
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
