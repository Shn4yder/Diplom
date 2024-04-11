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
        System.Drawing.Image image;
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

                image = System.Drawing.Image.FromFile(openDialog.FileName);
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
            this.Close();
            Goods_adm gds_frm = new Goods_adm(id_user, status, name_usr);
            gds_frm.Show();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            GoodModel new_good = new GoodModel();

            new_good.Name = name_tB.Text;
            new_good.Cost = Convert.ToDouble(price_tB.Text);
            new_good.Img = ImageManager.Saveimage(image_pB.Image);

            AddNewGood(new_good);

            this.Close();
            Goods_adm gds_frm = new Goods_adm(id_user, status, name_usr);
            gds_frm.Show();
        }

        private void AddNewGood(GoodModel good)
        {
            DataManager.AddGood(good);
        }
        // pictureBox1.Image == null нет картинки 
    }
}
