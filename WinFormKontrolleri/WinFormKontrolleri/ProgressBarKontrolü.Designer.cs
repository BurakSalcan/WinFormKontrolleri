﻿namespace WinFormKontrolleri
{
    partial class ProgressBarKontrolü
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
            this.components = new System.ComponentModel.Container();
            this.pb_cubuk = new System.Windows.Forms.ProgressBar();
            this.btn_ilerle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_saat = new System.Windows.Forms.ProgressBar();
            this.pb_dakika = new System.Windows.Forms.ProgressBar();
            this.pb_saniye = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pb_cubuk
            // 
            this.pb_cubuk.Location = new System.Drawing.Point(12, 49);
            this.pb_cubuk.Name = "pb_cubuk";
            this.pb_cubuk.Size = new System.Drawing.Size(247, 33);
            this.pb_cubuk.TabIndex = 0;
            // 
            // btn_ilerle
            // 
            this.btn_ilerle.Location = new System.Drawing.Point(266, 49);
            this.btn_ilerle.Name = "btn_ilerle";
            this.btn_ilerle.Size = new System.Drawing.Size(109, 32);
            this.btn_ilerle.TabIndex = 1;
            this.btn_ilerle.Text = "->";
            this.btn_ilerle.UseVisualStyleBackColor = true;
            this.btn_ilerle.Click += new System.EventHandler(this.btn_ilerle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlerleme Çubuğu";
            // 
            // pb_saat
            // 
            this.pb_saat.Location = new System.Drawing.Point(158, 156);
            this.pb_saat.Maximum = 23;
            this.pb_saat.Name = "pb_saat";
            this.pb_saat.Size = new System.Drawing.Size(426, 36);
            this.pb_saat.Step = 1;
            this.pb_saat.TabIndex = 3;
            // 
            // pb_dakika
            // 
            this.pb_dakika.Location = new System.Drawing.Point(158, 199);
            this.pb_dakika.Maximum = 60;
            this.pb_dakika.Name = "pb_dakika";
            this.pb_dakika.Size = new System.Drawing.Size(426, 36);
            this.pb_dakika.Step = 1;
            this.pb_dakika.TabIndex = 4;
            // 
            // pb_saniye
            // 
            this.pb_saniye.Location = new System.Drawing.Point(158, 243);
            this.pb_saniye.Maximum = 60;
            this.pb_saniye.Name = "pb_saniye";
            this.pb_saniye.Size = new System.Drawing.Size(426, 36);
            this.pb_saniye.Step = 1;
            this.pb_saniye.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "SAAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "DAKİKA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "SANİYE:";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(226, 107);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(87, 29);
            this.lbl_tarih.TabIndex = 9;
            this.lbl_tarih.Text = "label5";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(591, 168);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(43, 16);
            this.lbl_saat.TabIndex = 10;
            this.lbl_saat.Text = "SAAT";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(591, 211);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(54, 16);
            this.lbl_dakika.TabIndex = 11;
            this.lbl_dakika.Text = "DAKİKA";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(591, 255);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(56, 16);
            this.lbl_saniye.TabIndex = 12;
            this.lbl_saniye.Text = "SANİYE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBarKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_saniye);
            this.Controls.Add(this.pb_dakika);
            this.Controls.Add(this.pb_saat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ilerle);
            this.Controls.Add(this.pb_cubuk);
            this.Name = "ProgressBarKontrolü";
            this.Text = "ProgressBarKontrolü";
            this.Load += new System.EventHandler(this.ProgressBarKontrolü_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_cubuk;
        private System.Windows.Forms.Button btn_ilerle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb_saat;
        private System.Windows.Forms.ProgressBar pb_dakika;
        private System.Windows.Forms.ProgressBar pb_saniye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
    }
}