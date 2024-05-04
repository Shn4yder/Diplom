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
using diplom.DiplomUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using diplom.Controls;


namespace diplom
{
    public partial class Goods_adm : Form
    {
        string id_user, status, name_usr;
        bool sidebarExpand;   // состояние меню (открыто/закрыто)
        string order_mode = "ORDER BY id_good ASC";

        public Goods_adm(string id_user, string status, string name_usr)
        {
            InitializeComponent();

            goods_GV.DataSource = DataManager.LoadGoods(order_mode);   // загрузка данных в таблицу

            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;

            CheckRole(status);
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

        private void log_btn_Click(object sender, EventArgs e)
        {
            Logs form = new Logs(id_user, status, name_usr);
            this.Hide();
            form.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (status != "Администратор")
            {
                MailManager.SendReport(name_usr);   // по завершению смены отправляется отчет администраторам
            }
            Trigger.Addlog("exit", name_usr);
            this.Close();
        }
        //

        // Обработчик нажатия на кнопку "Создать"
        private void create_btn_Click(object sender, EventArgs e)
        {
            AddGood add_frm = new AddGood(id_user, status, name_usr);
            this.Hide();
            add_frm.Show();
        }

        private void change_tarif_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            price_tB.Visible = true;
            save_tarif_btn.Visible = true;  
            label2.Visible = true;  
            price_tB.Text = DataManager.LoadTarif().ToString();
        }

        private void save_tarif_btn_Click(object sender, EventArgs e)
        {
            DataManager.UpdateGood(new GoodModel("", "тариф руб/мин", Convert.ToDouble(price_tB.Text)), "1");
            panel2.Visible = false;
            price_tB.Visible = false;
            save_tarif_btn.Visible = false;
            label2.Visible = false;
        }

        private void price_tB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(price_tB.Text);
            }
            catch 
            {
                MessageBox.Show("Стоимость тарифа должна быть положительным числом", "Внимание");
                price_tB.Text = DataManager.LoadTarif().ToString();
            }
        }

        private void order_cB_TextChanged(object sender, EventArgs e)
        {
            if (order_cB.Text == "По возрастанию цены")
            {
                order_mode = "ORDER BY cost ASC";
            }
            else if (order_cB.Text == "По убыванию цены")
            {
                order_mode = "ORDER BY cost DESC";
            }
            else  
            {
                order_mode = "ORDER BY id_good ASC";
            }
            goods_GV.DataSource = DataManager.LoadGoods(order_mode);
        }

        // Обработчик двойного нажатия на ячейку с товаром
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

        // Проверка роли пользователя - создавать товар и заходить на вкладку "Пользователи" может только администратор
        private void CheckRole(string role)
        {
            if (role != "Администратор")
            {   
                // скрыть и отключить кнопки
                create_btn.Visible = false;
                create_btn.Enabled = false;
                usr_btn.Visible = false;
                usr_btn.Enabled = false;
                change_tarif_btn.Visible = false;
                change_tarif_btn.Enabled = false;   
                log_btn.Visible=false;
                log_btn.Enabled = false;    
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
