using ColorChanger2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChanger2.Utils
{
    public static class ResimHelper
    {
        public static Bitmap ResizeImage(Resim resim)
        {
            Bitmap newImage = new Bitmap(resim.new_width, resim.new_height);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(resim.orginal_bitmap, new Rectangle(0, 0, resim.new_width, resim.new_height));
            }

            return newImage;
        }
        public static void Crop(Resim resim)
        {
            Rectangle cropRect = new Rectangle(0, 0, resim.new_width, resim.new_height);
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
                g.DrawImage(resim.orginal_bitmap, new Rectangle(0, 0, target.Width, target.Height),
                                 cropRect,
                                 GraphicsUnit.Pixel);

            resim.orginal_bitmap = target;
        }
    }
}
