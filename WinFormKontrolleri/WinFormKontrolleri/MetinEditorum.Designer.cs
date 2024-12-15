namespace WinFormKontrolleri
{
    partial class MetinEditorum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetinEditorum));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ac = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_farkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_yazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.TSCB_font = new System.Windows.Forms.ToolStripComboBox();
            this.TSCB_size = new System.Windows.Forms.ToolStripComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TSBTN_fontDegistir = new System.Windows.Forms.ToolStripButton();
            this.TSBTN_renk = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ac,
            this.TSMI_yeni,
            this.toolStripSeparator3,
            this.TSMI_kaydet,
            this.TSMI_farkliKaydet,
            this.toolStripSeparator2,
            this.TSMI_yazdir,
            this.toolStripSeparator1,
            this.TSMI_kapat});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_ac
            // 
            this.TSMI_ac.Name = "TSMI_ac";
            this.TSMI_ac.Size = new System.Drawing.Size(266, 26);
            this.TSMI_ac.Text = "Aç";
            this.TSMI_ac.Click += new System.EventHandler(this.TSMI_ac_Click);
            // 
            // TSMI_yeni
            // 
            this.TSMI_yeni.Name = "TSMI_yeni";
            this.TSMI_yeni.Size = new System.Drawing.Size(266, 26);
            this.TSMI_yeni.Text = "Yeni";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(263, 6);
            // 
            // TSMI_kaydet
            // 
            this.TSMI_kaydet.Name = "TSMI_kaydet";
            this.TSMI_kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_kaydet.Size = new System.Drawing.Size(266, 26);
            this.TSMI_kaydet.Text = "Kaydet";
            this.TSMI_kaydet.Click += new System.EventHandler(this.TSMI_kaydet_Click);
            // 
            // TSMI_farkliKaydet
            // 
            this.TSMI_farkliKaydet.Name = "TSMI_farkliKaydet";
            this.TSMI_farkliKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMI_farkliKaydet.Size = new System.Drawing.Size(266, 26);
            this.TSMI_farkliKaydet.Text = "Farklı Kaydet";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // TSMI_yazdir
            // 
            this.TSMI_yazdir.Name = "TSMI_yazdir";
            this.TSMI_yazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.TSMI_yazdir.Size = new System.Drawing.Size(266, 26);
            this.TSMI_yazdir.Text = "Yazdır";
            this.TSMI_yazdir.Click += new System.EventHandler(this.TSMI_yazdir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // TSMI_kapat
            // 
            this.TSMI_kapat.Name = "TSMI_kapat";
            this.TSMI_kapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.TSMI_kapat.Size = new System.Drawing.Size(266, 26);
            this.TSMI_kapat.Text = "Kapat";
            this.TSMI_kapat.Click += new System.EventHandler(this.TSMI_kapat_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 397);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 422);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 397);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(458, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(129, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCB_font,
            this.TSCB_size,
            this.TSBTN_fontDegistir,
            this.TSBTN_renk});
            this.toolStrip2.Location = new System.Drawing.Point(0, 26);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(458, 28);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // TSCB_font
            // 
            this.TSCB_font.Name = "TSCB_font";
            this.TSCB_font.Size = new System.Drawing.Size(121, 28);
            this.TSCB_font.SelectedIndexChanged += new System.EventHandler(this.TSCB_font_SelectedIndexChanged);
            // 
            // TSCB_size
            // 
            this.TSCB_size.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "18",
            "24",
            "28",
            "36",
            "48",
            "72"});
            this.TSCB_size.Name = "TSCB_size";
            this.TSCB_size.Size = new System.Drawing.Size(121, 28);
            this.TSCB_size.SelectedIndexChanged += new System.EventHandler(this.TSCB_size_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // TSBTN_fontDegistir
            // 
            this.TSBTN_fontDegistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBTN_fontDegistir.Image = ((System.Drawing.Image)(resources.GetObject("TSBTN_fontDegistir.Image")));
            this.TSBTN_fontDegistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTN_fontDegistir.Name = "TSBTN_fontDegistir";
            this.TSBTN_fontDegistir.Size = new System.Drawing.Size(98, 25);
            this.TSBTN_fontDegistir.Text = "Font Değiştir";
            this.TSBTN_fontDegistir.Click += new System.EventHandler(this.TSBTN_fontDegistir_Click);
            // 
            // TSBTN_renk
            // 
            this.TSBTN_renk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBTN_renk.Image = ((System.Drawing.Image)(resources.GetObject("TSBTN_renk.Image")));
            this.TSBTN_renk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTN_renk.Name = "TSBTN_renk";
            this.TSBTN_renk.Size = new System.Drawing.Size(101, 25);
            this.TSBTN_renk.Text = "Renk Değiştir";
            this.TSBTN_renk.Click += new System.EventHandler(this.TSBTN_renk_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // MetinEditorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MetinEditorum";
            this.Text = "MetinEditorum";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ac;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yeni;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_farkliKaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yazdir;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kapat;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox TSCB_font;
        private System.Windows.Forms.ToolStripComboBox TSCB_size;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripButton TSBTN_fontDegistir;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton TSBTN_renk;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}