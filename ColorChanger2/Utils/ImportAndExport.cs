using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChanger2.Utils
{
    public static class ImportAndExport
    {
        public static string SavePath()
        {
            string path = "";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    path = fbd.SelectedPath;
                
            }
            return path;
        }
        public static string OpenPath()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Fotoğraf |*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
                return file.FileName;
            else
                return "";
        }
        public static Bitmap RecieveBitmap(string file_path)
        {
            Bitmap mBitmap = null;
            using (Stream BitmapStream = File.Open(file_path, FileMode.Open))
            {
                var img = Image.FromStream(BitmapStream);
                mBitmap = new Bitmap(img);
            }

            return mBitmap;
        }
    }
}
