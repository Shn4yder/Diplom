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
    public partial class AddOrder : Form
    {
        string id_user, status, name_usr;
        public AddOrder(string id_user, string status, string name_usr)
        {
            InitializeComponent();

            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
        }

        // Обработчик нажатия на кнопку "Назад"
        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        //Обработчик нажатия на кнопку "Создать"
        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_tB.Text != "" & numb_tB.Text != "")
            {
                OrderModel new_order = new OrderModel(numb_tB.Text, name_tB.Text, Convert.ToInt16(ppl_UpDown.Value), DateTime.Now.ToString(), comment_tB.Text, Convert.ToInt16(id_user));
                AddNewOrder(new_order);

                GoBack();
            }
            else { MessageBox.Show("Пожалуйста, заполните все поля, отмеченные * ", "Внимание"); }
        }

        private void AddNewOrder(OrderModel order)
        {
            DataManager.AddOrder(order);
        }

        // Проверка полей на отсутствие значений
        private void name_tB_TextChanged(object sender, EventArgs e)
        {
            if (name_tB.Text == "") { name_lbl.Visible = true; }
            else { name_lbl.Visible = false; }
        }

        private void numb_tB_TextChanged(object sender, EventArgs e)
        {
            if (numb_tB.Text == "") {  numb_lbl.Visible = true; }
            else { numb_lbl.Visible = false;}
        }
        //

        // Возврат на родительскую форму
        private void GoBack()
        {
            this.Close();
            Orders ord_frm = new Orders(id_user, status, name_usr);
            ord_frm.Show();
        }
    }
}
