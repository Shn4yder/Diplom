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
    public partial class Users : Form
    {
        List<UsersModel> users = new List<UsersModel>(); 
        
        public Users()
        {
            InitializeComponent();
            users = DataManager.LoadUsers();
            usr_GV.DataSource = users;
        }


        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_adm gds_frm = new Goods_adm();
            this.Hide();
            gds_frm.Show();
        }

        private void note_MenuItem_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            this.Hide();
            notes.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddUser add_frm = new AddUser();
            add_frm.Show();
            this.Hide();
        }

        private void usr_GV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = usr_GV.CurrentRow.Cells[0].Value.ToString();

            EditUsrForm edit_frm = new EditUsrForm(id);
            edit_frm.Show();
            this.Hide();
            
        }
    }
}
