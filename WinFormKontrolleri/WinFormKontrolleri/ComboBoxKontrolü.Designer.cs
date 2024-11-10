namespace WinFormKontrolleri
{
    partial class ComboBoxKontrolü
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
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_departmanSec = new System.Windows.Forms.Button();
            this.lbl_secilenDepartman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_egitim = new System.Windows.Forms.ComboBox();
            this.lbl_eğitim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_markalar = new System.Windows.Forms.ComboBox();
            this.btn_markaSeç = new System.Windows.Forms.Button();
            this.lbl_marka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_departman
            // 
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Items.AddRange(new object[] {
            "Satış",
            "Muhasebe",
            "Levazım",
            "İnsan Kaynakları"});
            this.cb_departman.Location = new System.Drawing.Point(50, 35);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(217, 24);
            this.cb_departman.TabIndex = 0;
            this.cb_departman.Text = "Seçiniz...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departman Seçiniz";
            // 
            // btn_departmanSec
            // 
            this.btn_departmanSec.Location = new System.Drawing.Point(274, 35);
            this.btn_departmanSec.Name = "btn_departmanSec";
            this.btn_departmanSec.Size = new System.Drawing.Size(75, 23);
            this.btn_departmanSec.TabIndex = 2;
            this.btn_departmanSec.Text = "Seç";
            this.btn_departmanSec.UseVisualStyleBackColor = true;
            this.btn_departmanSec.Click += new System.EventHandler(this.btn_departmanSec_Click);
            // 
            // lbl_secilenDepartman
            // 
            this.lbl_secilenDepartman.AutoSize = true;
            this.lbl_secilenDepartman.Location = new System.Drawing.Point(355, 38);
            this.lbl_secilenDepartman.Name = "lbl_secilenDepartman";
            this.lbl_secilenDepartman.Size = new System.Drawing.Size(122, 16);
            this.lbl_secilenDepartman.TabIndex = 3;
            this.lbl_secilenDepartman.Text = "Seçilen Departman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Katılınacak Eğitim";
            // 
            // cb_egitim
            // 
            this.cb_egitim.FormattingEnabled = true;
            this.cb_egitim.Items.AddRange(new object[] {
            "Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı",
            "İleri Sürüş Eğitimi",
            "Domates Yetiştiriciliği",
            "Levazım Uzmanlığı"});
            this.cb_egitim.Location = new System.Drawing.Point(50, 106);
            this.cb_egitim.Name = "cb_egitim";
            this.cb_egitim.Size = new System.Drawing.Size(214, 24);
            this.cb_egitim.TabIndex = 5;
            this.cb_egitim.Text = "Seçiniz...";
            this.cb_egitim.SelectedIndexChanged += new System.EventHandler(this.cb_eğitim_SelectedIndexChanged);
            // 
            // lbl_eğitim
            // 
            this.lbl_eğitim.AutoSize = true;
            this.lbl_eğitim.Location = new System.Drawing.Point(270, 109);
            this.lbl_eğitim.Name = "lbl_eğitim";
            this.lbl_eğitim.Size = new System.Drawing.Size(91, 16);
            this.lbl_eğitim.TabIndex = 6;
            this.lbl_eğitim.Text = "Seçilen eğitim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Markalar";
            // 
            // cb_markalar
            // 
            this.cb_markalar.FormattingEnabled = true;
            this.cb_markalar.Location = new System.Drawing.Point(50, 179);
            this.cb_markalar.Name = "cb_markalar";
            this.cb_markalar.Size = new System.Drawing.Size(214, 24);
            this.cb_markalar.TabIndex = 8;
            // 
            // btn_markaSeç
            // 
            this.btn_markaSeç.Location = new System.Drawing.Point(271, 179);
            this.btn_markaSeç.Name = "btn_markaSeç";
            this.btn_markaSeç.Size = new System.Drawing.Size(75, 23);
            this.btn_markaSeç.TabIndex = 9;
            this.btn_markaSeç.Text = "Seç";
            this.btn_markaSeç.UseVisualStyleBackColor = true;
            this.btn_markaSeç.Click += new System.EventHandler(this.btn_markaSeç_Click);
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.Location = new System.Drawing.Point(353, 186);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(93, 16);
            this.lbl_marka.TabIndex = 10;
            this.lbl_marka.Text = "Seçilen Marka";
            // 
            // ComboBoxKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_marka);
            this.Controls.Add(this.btn_markaSeç);
            this.Controls.Add(this.cb_markalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_eğitim);
            this.Controls.Add(this.cb_egitim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_secilenDepartman);
            this.Controls.Add(this.btn_departmanSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_departman);
            this.Name = "ComboBoxKontrolü";
            this.Text = "ComboBoxKontrolü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_departmanSec;
        private System.Windows.Forms.Label lbl_secilenDepartman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_egitim;
        private System.Windows.Forms.Label lbl_eğitim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_markalar;
        private System.Windows.Forms.Button btn_markaSeç;
        private System.Windows.Forms.Label lbl_marka;
    }
}