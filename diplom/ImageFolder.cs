using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace diplom
{
    internal class ImageFolder
    {
        

        public ImageFolder() { }    

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

        public static string Saveimage(System.Drawing.Image image) 
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
            string folderName = @"C:\Art_coworking\";
            try
            {
                string number = new DirectoryInfo(folderName).GetFiles().Length.ToString();
                string path = folderName + "image" + (Convert.ToInt16(number) + 1).ToString() + ".jpg";
                return path;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        public static void DeleteImage(string img_name)
        {
            string folderName = @"C:\Art_coworking\";
            string path = folderName + img_name;

            try { File.Delete(path); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            File.Delete(path);
        }
    }
}
