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


namespace diplom
{
    public partial class Authorization : Form
    {
        bool show_pass;

        public Authorization()
        {
            InitializeComponent();
            pass_tB.UseSystemPasswordChar = true;   // скрыть пароль
        }

        // // Обработчик нажатия на кнопку "Вход"
        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (login_tB.Text != "" & pass_tB.Text != "")
            {
                UsersModel user = DataManager.Search(login_tB.Text, pass_tB.Text); // поиск пользователя по логину и паролю

                if (user != null)
                {
                    Trigger.Addlog("enter", user.Fio);
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
            else { MessageBox.Show("Пожалуйста, заполните все поля, отмеченные * ", "Внимание"); }
        }

        // Скрыть/показать пароль
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

        // Проверка полей на отсутствие значений
        private void login_tB_TextChanged(object sender, EventArgs e)
        {
            if (login_tB.Text == "") { login_lbl.Visible = true; }
            else { login_lbl.Visible = false; }
        }

        private void pass_tB_TextChanged(object sender, EventArgs e)
        {
            if (pass_tB.Text == "") { pass_lbl.Visible = true; }
            else { pass_lbl.Visible = false; }
        }
        //
    }
}
