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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diplom
{
    public partial class AddGood : Form
    {
        string id_user, status, name_usr;

        public AddGood(string id_user, string status, string name_usr)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;
        }

        private void add_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";

            if (openDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                // вывод картинки
                System.Drawing.Image image = System.Drawing.Image.FromFile(openDialog.FileName);
                Bitmap img = new Bitmap(image, new Size(150, 100));
                image_pB.Image = img;
            }
            catch
            {
                MessageBox.Show("Ошибка чтения изображения");
                return;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_tB.Text != "" & price_tB.Text != "")
            {
                GoodModel new_good = new GoodModel(ImageManager.Saveimage(image_pB.Image), name_tB.Text, Convert.ToDouble(price_tB.Text));
                AddNewGood(new_good);

                GoBack();
            }
            else { MessageBox.Show("Пожалуйста, заполните все поля, отмеченные * ", "Внимание"); }
        }

        private void name_tB_TextChanged(object sender, EventArgs e)
        {
            if (name_tB.Text == "") { name_lbl.Visible = true; }
            else { name_lbl.Visible = false; }
        }

        private void price_tB_TextChanged(object sender, EventArgs e)
        {
            if (price_tB.Text == "") { price_lbl.Visible = true; }
            else
            {
                try
                {
                    Convert.ToDouble(price_tB.Text);
                    price_lbl.Visible = false;
                }
                catch
                {
                    price_tB.Text = "";
                    MessageBox.Show("Стоимость должна быть положительным числом");
                    price_lbl.Visible = true;
                }
            }
        }

        private void AddNewGood(GoodModel good)
        {
            DataManager.AddGood(good);
        }

        private void GoBack()
        {
            this.Close();
            Goods_adm gds_frm = new Goods_adm(id_user, status, name_usr);
            gds_frm.Show();
        }
    }
}
