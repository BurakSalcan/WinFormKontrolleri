namespace WinFormKontrolleri
{
    partial class MDIIcinAnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_metinAraclari = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MetinEditorumAc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.metinİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // metinİşlemleriToolStripMenuItem
            // 
            this.metinİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_metinAraclari,
            this.TSMI_MetinEditorumAc});
            this.metinİşlemleriToolStripMenuItem.Name = "metinİşlemleriToolStripMenuItem";
            this.metinİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.metinİşlemleriToolStripMenuItem.Text = "Metin İşlemleri";
            // 
            // TSMI_metinAraclari
            // 
            this.TSMI_metinAraclari.Name = "TSMI_metinAraclari";
            this.TSMI_metinAraclari.Size = new System.Drawing.Size(224, 26);
            this.TSMI_metinAraclari.Text = "Metin Araçları";
            this.TSMI_metinAraclari.Click += new System.EventHandler(this.TSMI_metinAraclari_Click);
            // 
            // TSMI_MetinEditorumAc
            // 
            this.TSMI_MetinEditorumAc.Name = "TSMI_MetinEditorumAc";
            this.TSMI_MetinEditorumAc.Size = new System.Drawing.Size(224, 26);
            this.TSMI_MetinEditorumAc.Text = "Metin Editörüm";
            this.TSMI_MetinEditorumAc.Click += new System.EventHandler(this.TSMI_MetinEditorumAc_Click);
            // 
            // MDIIcinAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIIcinAnaForm";
            this.Text = "MDIIcinAnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metinİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_metinAraclari;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MetinEditorumAc;
    }
}