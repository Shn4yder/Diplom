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
    public partial class Users : Form
    {
        string id_user, sts, name_usr;
        bool sidebarExpand;

        public Users(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            usr_GV.DataSource = DataManager.LoadUsers();
            this.id_user = id_user;
            this.sts = status;
            this.name_usr = name_usr;
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
            Goods_adm gds_frm = new Goods_adm(id_user, sts, name_usr);
            this.Hide();
            gds_frm.Show();
        }

        private void note_btn_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes(id_user, sts, name_usr);
            this.Hide();
            notes.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            AddUser add_frm = new AddUser(id_user, sts, name_usr);
            add_frm.Show();
            this.Hide();
        }

        private void usr_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = usr_GV.CurrentRow.Cells[0].Value.ToString();

            EditUsrForm edit_frm = new EditUsrForm(id, id_user, sts, name_usr);
            edit_frm.Show();
            this.Hide();
        }
    }
}
