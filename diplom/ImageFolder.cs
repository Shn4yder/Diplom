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
        string folderName = @"C:\Art_coworking\";

        public ImageFolder() { }    

        public void CreateFolder()    // метод, создающий папку для хранения изображений
        {
            DirectoryInfo folder = new DirectoryInfo(folderName);
            if (!folder.Exists)
            {
                folder.Create();
                folder.Attributes = FileAttributes.Hidden;    // скрытая папка
            }
        }

        public void Saveimage(System.Drawing.Image image) 
        {
            image.Save(GiveImgName());
        }

        public string GiveImgName()    // создание уникального имени для изображения
        {
            string number = new DirectoryInfo(folderName).GetFiles().Length.ToString();
            string path = folderName + "image" + (Convert.ToInt16(number) + 1).ToString() + ".jpg";
            return path;
        }

        public void DeleteImage(string img_name)
        {
            string path = folderName + img_name;
            File.Delete(path);
        }
    }
}
