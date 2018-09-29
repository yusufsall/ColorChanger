namespace ColorChanger2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.current = new System.Windows.Forms.Label();
            this.current_bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 13);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(113, 23);
            this.load.TabIndex = 0;
            this.load.Text = "Resim Seç";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(149, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Location = new System.Drawing.Point(110, 43);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(61, 13);
            this.current.TabIndex = 7;
            this.current.Text = "Current: 0%";
            // 
            // current_bar
            // 
            this.current_bar.Location = new System.Drawing.Point(12, 59);
            this.current_bar.Name = "current_bar";
            this.current_bar.Size = new System.Drawing.Size(237, 23);
            this.current_bar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 98);
            this.Controls.Add(this.current_bar);
            this.Controls.Add(this.current);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Name = "Form1";
            this.Text = "Ders Notu Siyah Beyaz Çevirici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.ProgressBar current_bar;
    }
}

