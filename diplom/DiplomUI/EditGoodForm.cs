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
        List<GoodModel> good = new List<GoodModel>();
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
            good = DataManager.LoadGood(id_good);

            name_tB.Text = good[0].Name.ToString();
            img_tB.Text = good[0].Img.ToString();
            cost_tB.Text = good[0].Cost.ToString();
            image_pB.Image = good[0].image;

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DataManager.DeleteGood(id_good);

            Goods_adm form = new Goods_adm(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

        private void UpdateData()
        {

            GoodModel edit_good = new GoodModel();

            edit_good.Name = name_tB.Text;
            edit_good.Img = ImageManager.Saveimage(image_pB.Image);
            edit_good.Cost = Convert.ToDouble(cost_tB.Text);


            DataManager.UpdateGood(edit_good, id_good);

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            UpdateData();

            Goods_adm form = new Goods_adm(id_user, status, name_usr);
            form.Show();
            this.Close();
        }

        private void img_btn_Click(object sender, EventArgs e)
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
    }
}
