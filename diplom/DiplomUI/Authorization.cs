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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            List<UsersModel> user_list = new List<UsersModel>();
            UsersModel user = new UsersModel();
            user_list = DataManager.LoadAuthUser(pass_tB.Text, login_tB.Text);

            if (user_list.Count > 0)
            {
                user = user_list[0];

                if (user.Status == "Администратор")
                {
                    Goods_adm form = new Goods_adm(user.Id_user.ToString(), user.Status, user.Fio);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    Orders order_frm = new Orders(user.Id_user.ToString(), user.Status, user.Fio);
                    this.Hide();
                    order_frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Внимание");
            }


        }
    }
}
