using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom.DiplomUI
{
    public partial class Logs : Form
    {
        string id_user, sts, name_usr;
        bool sidebarExpand;  // состояние меню (открыто/закрыто)

        public Logs(string id_user, string status, string name_usr)
        {
            InitializeComponent();

            this.id_user = id_user;
            this.sts = status;
            this.name_usr = name_usr;

            log_GV.DataSource = DataManager.LoadLogs();
        }

        // обработчик таймера - закрывает/открывает меню
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

        // Открытие/закрытие меню
        private void sidebar_btn_Click(object sender, EventArgs e)
        {
            menu_timer.Start();
        }

        // Обработчики нажатия на кнопки меню
        private void items_btn_Click(object sender, EventArgs e)
        {
            Goods_adm gds_frm = new Goods_adm(id_user, sts, name_usr);
            this.Hide();
            gds_frm.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Trigger.Addlog("exit", name_usr);
            this.Close();   
        }

        private void note_btn_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes(id_user, sts, name_usr);
            this.Hide();
            notes.Show();
        }

        private void usr_btn_Click(object sender, EventArgs e)
        {
            Users users = new Users(id_user, sts, name_usr);
            this.Hide();
            users.Show();   
        }
        //

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteLogs();
            log_GV.DataSource = DataManager.LoadLogs();
        }
    }
}
