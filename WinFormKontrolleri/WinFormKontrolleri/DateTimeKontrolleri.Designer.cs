namespace WinFormKontrolleri
{
    partial class DateTimeKontrolleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_uretilen = new System.Windows.Forms.Label();
            this.nud_dakika = new System.Windows.Forms.NumericUpDown();
            this.nud_saat = new System.Windows.Forms.NumericUpDown();
            this.lbl_uzunTarih = new System.Windows.Forms.Label();
            this.lbl_kisaTarih = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.btn_tarihGetir = new System.Windows.Forms.Button();
            this.dtp_dogum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_tarihFarki = new System.Windows.Forms.Label();
            this.lbl_aralik = new System.Windows.Forms.Label();
            this.btn_aralik = new System.Windows.Forms.Button();
            this.mc_takvim = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_uretilen);
            this.groupBox1.Controls.Add(this.nud_dakika);
            this.groupBox1.Controls.Add(this.nud_saat);
            this.groupBox1.Controls.Add(this.lbl_uzunTarih);
            this.groupBox1.Controls.Add(this.lbl_kisaTarih);
            this.groupBox1.Controls.Add(this.lbl_tarih);
            this.groupBox1.Controls.Add(this.btn_tarihGetir);
            this.groupBox1.Controls.Add(this.dtp_dogum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doğum Tarihi";
            // 
            // lbl_uretilen
            // 
            this.lbl_uretilen.AutoSize = true;
            this.lbl_uretilen.Location = new System.Drawing.Point(18, 208);
            this.lbl_uretilen.Name = "lbl_uretilen";
            this.lbl_uretilen.Size = new System.Drawing.Size(53, 16);
            this.lbl_uretilen.TabIndex = 7;
            this.lbl_uretilen.Text = "Üretilen";
            // 
            // nud_dakika
            // 
            this.nud_dakika.Location = new System.Drawing.Point(134, 79);
            this.nud_dakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_dakika.Name = "nud_dakika";
            this.nud_dakika.Size = new System.Drawing.Size(100, 22);
            this.nud_dakika.TabIndex = 6;
            // 
            // nud_saat
            // 
            this.nud_saat.Location = new System.Drawing.Point(21, 79);
            this.nud_saat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_saat.Name = "nud_saat";
            this.nud_saat.Size = new System.Drawing.Size(100, 22);
            this.nud_saat.TabIndex = 5;
            // 
            // lbl_uzunTarih
            // 
            this.lbl_uzunTarih.AutoSize = true;
            this.lbl_uzunTarih.Location = new System.Drawing.Point(18, 182);
            this.lbl_uzunTarih.Name = "lbl_uzunTarih";
            this.lbl_uzunTarih.Size = new System.Drawing.Size(71, 16);
            this.lbl_uzunTarih.TabIndex = 4;
            this.lbl_uzunTarih.Text = "Uzun Tarih";
            // 
            // lbl_kisaTarih
            // 
            this.lbl_kisaTarih.AutoSize = true;
            this.lbl_kisaTarih.Location = new System.Drawing.Point(18, 158);
            this.lbl_kisaTarih.Name = "lbl_kisaTarih";
            this.lbl_kisaTarih.Size = new System.Drawing.Size(67, 16);
            this.lbl_kisaTarih.TabIndex = 3;
            this.lbl_kisaTarih.Text = "Kısa Tarih";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(18, 133);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(38, 16);
            this.lbl_tarih.TabIndex = 2;
            this.lbl_tarih.Text = "Tarih";
            // 
            // btn_tarihGetir
            // 
            this.btn_tarihGetir.Location = new System.Drawing.Point(240, 33);
            this.btn_tarihGetir.Name = "btn_tarihGetir";
            this.btn_tarihGetir.Size = new System.Drawing.Size(103, 24);
            this.btn_tarihGetir.TabIndex = 1;
            this.btn_tarihGetir.Text = "Tarih Getir";
            this.btn_tarihGetir.UseVisualStyleBackColor = true;
            this.btn_tarihGetir.Click += new System.EventHandler(this.btn_tarihGetir_Click);
            // 
            // dtp_dogum
            // 
            this.dtp_dogum.Location = new System.Drawing.Point(21, 35);
            this.dtp_dogum.Name = "dtp_dogum";
            this.dtp_dogum.Size = new System.Drawing.Size(213, 22);
            this.dtp_dogum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_tarihFarki);
            this.groupBox2.Controls.Add(this.lbl_aralik);
            this.groupBox2.Controls.Add(this.btn_aralik);
            this.groupBox2.Controls.Add(this.mc_takvim);
            this.groupBox2.Location = new System.Drawing.Point(375, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralama";
            // 
            // lbl_tarihFarki
            // 
            this.lbl_tarihFarki.AutoSize = true;
            this.lbl_tarihFarki.Location = new System.Drawing.Point(373, 84);
            this.lbl_tarihFarki.Name = "lbl_tarihFarki";
            this.lbl_tarihFarki.Size = new System.Drawing.Size(71, 16);
            this.lbl_tarihFarki.TabIndex = 3;
            this.lbl_tarihFarki.Text = "Tarih Farkı";
            // 
            // lbl_aralik
            // 
            this.lbl_aralik.AutoSize = true;
            this.lbl_aralik.Location = new System.Drawing.Point(373, 57);
            this.lbl_aralik.Name = "lbl_aralik";
            this.lbl_aralik.Size = new System.Drawing.Size(41, 16);
            this.lbl_aralik.TabIndex = 2;
            this.lbl_aralik.Text = "Aralık";
            // 
            // btn_aralik
            // 
            this.btn_aralik.Location = new System.Drawing.Point(370, 21);
            this.btn_aralik.Name = "btn_aralik";
            this.btn_aralik.Size = new System.Drawing.Size(86, 23);
            this.btn_aralik.TabIndex = 1;
            this.btn_aralik.Text = "Aralık";
            this.btn_aralik.UseVisualStyleBackColor = true;
            this.btn_aralik.Click += new System.EventHandler(this.btn_aralik_Click);
            // 
            // mc_takvim
            // 
            this.mc_takvim.Location = new System.Drawing.Point(6, 16);
            this.mc_takvim.Name = "mc_takvim";
            this.mc_takvim.ShowWeekNumbers = true;
            this.mc_takvim.TabIndex = 0;
            // 
            // DateTimeKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DateTimeKontrolleri";
            this.Text = "DateTimeKontrolleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Button btn_tarihGetir;
        private System.Windows.Forms.DateTimePicker dtp_dogum;
        private System.Windows.Forms.Label lbl_uzunTarih;
        private System.Windows.Forms.Label lbl_kisaTarih;
        private System.Windows.Forms.NumericUpDown nud_dakika;
        private System.Windows.Forms.NumericUpDown nud_saat;
        private System.Windows.Forms.Label lbl_uretilen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_aralik;
        private System.Windows.Forms.Button btn_aralik;
        private System.Windows.Forms.MonthCalendar mc_takvim;
        private System.Windows.Forms.Label lbl_tarihFarki;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}