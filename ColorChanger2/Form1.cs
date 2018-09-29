using ColorChanger2.Models;
using ColorChanger2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChanger2
{
    public partial class Form1 : Form
    {
        Resim resim = new Resim();
        Thread refresh_thread, render_thread;

        public static int current_yuzde = 0;

        public Form1()
        {
            InitializeComponent();
            refresh_thread = new Thread(refresh_gui);
            render_thread = new Thread(render);

            refresh_thread.Start();
        }
        private void refresh_gui()
        {
            while (true)
            {
                try
                {
                    current.Invoke((MethodInvoker)delegate {
                        current.Text = "Current: " + current_yuzde + "%";

                        if (current_yuzde == 100)
                            current.Text += " Tamamlandı.";
                        
                    });
                    current_bar.Invoke((MethodInvoker)delegate {
                        current_bar.Value = current_yuzde;
                    });
                }
                catch
                {
                }
                Thread.Sleep(1000);
            }
        }
        private void render()
        {
            this.Invoke((MethodInvoker)delegate { resim.save_path = ImportAndExport.SavePath(); });
            resim.converted_bitmap = ColorHelper.ConvertWhiteAndBlack(resim);
            resim.converted_bitmap = ResimHelper.ResizeImage(resim);
            resim.converted_bitmap.Save(resim.save_path + "/" + resim.name);
        }

        private void load_Click(object sender, EventArgs e)
        {
            resim.open_path = ImportAndExport.OpenPath();
            resim.name = Path.GetFileName(resim.open_path);
            resim.orginal_bitmap = ImportAndExport.RecieveBitmap(resim.open_path);
            resim.x_resulation = resim.orginal_bitmap.Width;
            resim.y_resulation = resim.orginal_bitmap.Height;
            resim.background_color = ColorHelper.DetermineColor(resim.orginal_bitmap);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (refresh_thread != null)
                refresh_thread.Abort();

            if (render_thread != null)
                render_thread.Abort();
            
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (!render_thread.IsAlive)
                render_thread.Start();
            else
                MessageBox.Show("Şuanda çalışıyor.");
        }
    }
}
