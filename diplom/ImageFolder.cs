using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace diplom
{
    internal class ImageFolder
    {

        public static void CreateFolder()    // метод, создающий папку для хранения изображений
        {
            string folderName = @"C:\Art_coworking\"; 

            DirectoryInfo folder = new DirectoryInfo(folderName);
            if (!folder.Exists)
            {
                folder.Create();
                folder.Attributes = FileAttributes.Hidden;    // скрытая папка
            }
        }

        public static string Saveimage(Image image) 
        {
            CreateFolder();
            string save_path = GiveImgName();

            if (image != null)
            {
                image.Save(save_path);
            }
            else
            {
                save_path = "no save path or nothing to save";
            }
            return save_path;
        }

        public static string GiveImgName()    // создание уникального имени для изображения
        {
            Random random = new Random();

            string folderName = @"C:\Art_coworking\";
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string img_name = String.Concat<char>(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());
            string path = folderName + img_name + ".jpg";
            return path;   
        }

        public static void DeleteImage(string path)
        {
            //try { File.Delete(path); }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            File.Delete(path);
        }

        public static Image GetImage(string path)
        {
            Image img = Image.FromFile(path);
            return img;
        }
    }
}
