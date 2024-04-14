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
using Image = System.Drawing.Image;

namespace diplom
{
    public partial class EditGoodForm : Form
    {
        string id_good, id_user, status, name_usr;
        public EditGoodForm(string id_good, string id_user, string status, string name_usr)
        {
            InitializeComponent();
            this.id_good = id_good;
            this.id_user = id_user;
            this.status = status;
            this.name_usr = name_usr;

            GetGood();
        }

        private void GetGood()
        {
            List<GoodModel> good = DataManager.LoadGood(id_good);

            name_tB.Text = good[0].Name.ToString();
            cost_tB.Text = good[0].Cost.ToString();
            image_pB.Image = good[0].image;
        }

        private void add_photo_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";

            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                // вывод картинки

                Image image = Image.FromFile(openDialog.FileName);
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

        private void del_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteGood(id_good);

            GoBack();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            GoBack();
        }

        private void UpdateData()
        {
            GoodModel edit_good = new GoodModel(ImageManager.Saveimage(image_pB.Image), name_tB.Text, Convert.ToDouble(cost_tB.Text));
            DataManager.UpdateGood(edit_good, id_good);
        }

        private void GoBack()
        {
            Goods_adm form = new Goods_adm(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

    }
}
