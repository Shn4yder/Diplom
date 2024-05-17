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
using Excel = Microsoft.Office.Interop.Excel;


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
            Application.Exit();
        }

        private void note_btn_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes(id_user, sts, name_usr);
            this.Hide();
            notes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private void excel_btn_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Worksheet xlSheet = null;
            Excel.Range xlSheetRange = null;

            xlApp = new Excel.Application();

            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные";

                //Выгрузка данных
                DataTable dt = GetData();

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);
            }
        }

        //Освобождаем ресуры (закрываем Excel)
        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }

        private DataTable GetData()
        {
            var dt = new DataTable("tableName");
            List<LogsModel> logs = DataManager.LoadLogs();

            // create fields
            dt.Columns.Add("№", typeof(string));
            dt.Columns.Add("Дата", typeof(string));
            dt.Columns.Add("Событие", typeof(string));
            dt.Columns.Add("Причина", typeof(string));
            dt.Columns.Add("Пользователь", typeof(string));
            dt.Columns.Add("Система", typeof(string));

            foreach (var log in logs)
            {
                dt.Rows.Add(log.Id_log, log.Date_log, log.Event, log.Cause, log.User, log.System);
            }

            return dt;
        }
    }
}
