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

namespace diplom
{
    public partial class AddGood : Form
    {
        System.Drawing.Image image;

        public AddGood()
        {
            InitializeComponent();
        }

        private void add_image_btn_Click(object sender, EventArgs e)
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
                pictureBox1.Image = img;

                // перенести в save-button
                /*ImageFolder folder = new ImageFolder();
                folder.Saveimage(img);*/
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения изображения");
                return;
            }
        }

        // pictureBox1.Image == null нет картинки 
    }
}
