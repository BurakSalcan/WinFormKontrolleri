namespace WinFormKontrolleri
{
    partial class CheckBoxRadioButton
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
            this.cb_secim = new System.Windows.Forms.CheckBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.rbtn_evli = new System.Windows.Forms.RadioButton();
            this.rbtn_bekar = new System.Windows.Forms.RadioButton();
            this.cb_ingilizce = new System.Windows.Forms.CheckBox();
            this.cb_almanca = new System.Windows.Forms.CheckBox();
            this.cb_swahilce = new System.Windows.Forms.CheckBox();
            this.rbtn_erkek = new System.Windows.Forms.RadioButton();
            this.rbtn_kadin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran2 = new System.Windows.Forms.Label();
            this.lbl_ekran3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_secim
            // 
            this.cb_secim.AutoSize = true;
            this.cb_secim.Location = new System.Drawing.Point(12, 12);
            this.cb_secim.Name = "cb_secim";
            this.cb_secim.Size = new System.Drawing.Size(196, 20);
            this.cb_secim.TabIndex = 0;
            this.cb_secim.Text = "Sözleşmeyi Kabul Ediyorum";
            this.cb_secim.UseVisualStyleBackColor = true;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(12, 50);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(75, 23);
            this.btn_gonder.TabIndex = 1;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(12, 89);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran.TabIndex = 2;
            this.lbl_ekran.Text = "label1";
            // 
            // rbtn_evli
            // 
            this.rbtn_evli.AutoSize = true;
            this.rbtn_evli.Location = new System.Drawing.Point(17, 29);
            this.rbtn_evli.Name = "rbtn_evli";
            this.rbtn_evli.Size = new System.Drawing.Size(50, 20);
            this.rbtn_evli.TabIndex = 3;
            this.rbtn_evli.TabStop = true;
            this.rbtn_evli.Text = "Evli";
            this.rbtn_evli.UseVisualStyleBackColor = true;
            // 
            // rbtn_bekar
            // 
            this.rbtn_bekar.AutoSize = true;
            this.rbtn_bekar.Location = new System.Drawing.Point(112, 29);
            this.rbtn_bekar.Name = "rbtn_bekar";
            this.rbtn_bekar.Size = new System.Drawing.Size(64, 20);
            this.rbtn_bekar.TabIndex = 4;
            this.rbtn_bekar.TabStop = true;
            this.rbtn_bekar.Text = "Bekar";
            this.rbtn_bekar.UseVisualStyleBackColor = true;
            // 
            // cb_ingilizce
            // 
            this.cb_ingilizce.AutoSize = true;
            this.cb_ingilizce.Location = new System.Drawing.Point(14, 34);
            this.cb_ingilizce.Name = "cb_ingilizce";
            this.cb_ingilizce.Size = new System.Drawing.Size(77, 20);
            this.cb_ingilizce.TabIndex = 5;
            this.cb_ingilizce.Text = "İngilizce";
            this.cb_ingilizce.UseVisualStyleBackColor = true;
            // 
            // cb_almanca
            // 
            this.cb_almanca.AutoSize = true;
            this.cb_almanca.Location = new System.Drawing.Point(14, 61);
            this.cb_almanca.Name = "cb_almanca";
            this.cb_almanca.Size = new System.Drawing.Size(82, 20);
            this.cb_almanca.TabIndex = 6;
            this.cb_almanca.Text = "Almanca";
            this.cb_almanca.UseVisualStyleBackColor = true;
            // 
            // cb_swahilce
            // 
            this.cb_swahilce.AutoSize = true;
            this.cb_swahilce.Location = new System.Drawing.Point(14, 88);
            this.cb_swahilce.Name = "cb_swahilce";
            this.cb_swahilce.Size = new System.Drawing.Size(83, 20);
            this.cb_swahilce.TabIndex = 7;
            this.cb_swahilce.Text = "Swahilce";
            this.cb_swahilce.UseVisualStyleBackColor = true;
            // 
            // rbtn_erkek
            // 
            this.rbtn_erkek.AutoSize = true;
            this.rbtn_erkek.Location = new System.Drawing.Point(17, 29);
            this.rbtn_erkek.Name = "rbtn_erkek";
            this.rbtn_erkek.Size = new System.Drawing.Size(63, 20);
            this.rbtn_erkek.TabIndex = 8;
            this.rbtn_erkek.TabStop = true;
            this.rbtn_erkek.Text = "Erkek";
            this.rbtn_erkek.UseVisualStyleBackColor = true;
            // 
            // rbtn_kadin
            // 
            this.rbtn_kadin.AutoSize = true;
            this.rbtn_kadin.Location = new System.Drawing.Point(111, 29);
            this.rbtn_kadin.Name = "rbtn_kadin";
            this.rbtn_kadin.Size = new System.Drawing.Size(62, 20);
            this.rbtn_kadin.TabIndex = 9;
            this.rbtn_kadin.TabStop = true;
            this.rbtn_kadin.Text = "Kadın";
            this.rbtn_kadin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_kadin);
            this.groupBox1.Controls.Add(this.rbtn_erkek);
            this.groupBox1.Location = new System.Drawing.Point(238, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_evli);
            this.groupBox2.Controls.Add(this.rbtn_bekar);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 68);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medeni Durum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_ingilizce);
            this.groupBox3.Controls.Add(this.cb_almanca);
            this.groupBox3.Controls.Add(this.cb_swahilce);
            this.groupBox3.Location = new System.Drawing.Point(8, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 132);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diller";
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(238, 216);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 23);
            this.btn_getir.TabIndex = 13;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran2
            // 
            this.lbl_ekran2.AutoSize = true;
            this.lbl_ekran2.Location = new System.Drawing.Point(334, 223);
            this.lbl_ekran2.Name = "lbl_ekran2";
            this.lbl_ekran2.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran2.TabIndex = 14;
            this.lbl_ekran2.Text = "label1";
            // 
            // lbl_ekran3
            // 
            this.lbl_ekran3.AutoSize = true;
            this.lbl_ekran3.Location = new System.Drawing.Point(334, 249);
            this.lbl_ekran3.Name = "lbl_ekran3";
            this.lbl_ekran3.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran3.TabIndex = 15;
            this.lbl_ekran3.Text = "label1";
            // 
            // CheckBoxRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.lbl_ekran3);
            this.Controls.Add(this.lbl_ekran2);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.cb_secim);
            this.Name = "CheckBoxRadioButton";
            this.Text = "CheckBoxRadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_secim;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.RadioButton rbtn_evli;
        private System.Windows.Forms.RadioButton rbtn_bekar;
        private System.Windows.Forms.CheckBox cb_ingilizce;
        private System.Windows.Forms.CheckBox cb_almanca;
        private System.Windows.Forms.CheckBox cb_swahilce;
        private System.Windows.Forms.RadioButton rbtn_erkek;
        private System.Windows.Forms.RadioButton rbtn_kadin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran2;
        private System.Windows.Forms.Label lbl_ekran3;
    }
}