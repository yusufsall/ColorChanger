using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChanger2.Models
{
    public class Resim
    {
        public string name = "";
        public string open_path = "";
        public string save_path = "";
        public int x_resulation = 0;
        public int y_resulation = 0;
        public int new_width = 0;
        public int new_height = 0;
        public Color background_color = Color.Empty;
        public Bitmap converted_bitmap = null;
        public Bitmap orginal_bitmap = null;
        public List<Boya> boyalar = new List<Boya>();
    }
}
