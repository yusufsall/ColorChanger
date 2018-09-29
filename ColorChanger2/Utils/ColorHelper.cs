using ColorChanger2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChanger2.Utils
{
    public static class ColorHelper
    {
        public static Color DetermineColor(Bitmap bitmap)
        {
            var _bitmap = new Bitmap(bitmap, bitmap.Width / 5, bitmap.Height / 5);
            var colors = new List<Color>();

            for (int x = 0; x < _bitmap.Width; x++)
                for (int y = 0; y < _bitmap.Height; y++)
                    colors.Add(_bitmap.GetPixel(x, y));

            var r = colors.Sum(u => u.R);
            var g = colors.Sum(u => u.G);
            var b = colors.Sum(u => u.B);

            r /= colors.Count;
            g /= colors.Count;
            b /= colors.Count;

            colors = null;
            _bitmap = null;

            return Color.FromArgb(r, g, b);
        }

        public static Bitmap ConvertWhiteAndBlack(Resim resim)
        {
            var _color = resim.background_color;
            var target = resim.orginal_bitmap;

            for (int x = 0; x < target.Width; x++)
            {
                for (int y = 0; y < target.Height; y++)
                {
                    var color = target.GetPixel(x, y);
                    var boya = new Boya();
                    boya.x = x;
                    boya.y = y;
                    if (color.R > _color.R * 85 / 100 && color.G > _color.G * 85 / 100 && color.B > _color.B * 85 / 100)
                    {
                        target.SetPixel(x, y, Color.White);
                        boya.isWhite = true;
                    }
                    else
                    {
                        target.SetPixel(x, y, Color.Black);
                        boya.isWhite = false;
                    }
                    resim.boyalar.Add(boya);
                }
                Form1.current_yuzde = Convert.ToInt32(((float)x / target.Width) * 100);
            }
            return target;
        }
    }
}
