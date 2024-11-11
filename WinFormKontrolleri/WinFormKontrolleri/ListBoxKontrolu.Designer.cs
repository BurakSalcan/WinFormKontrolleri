namespace WinFormKontrolleri
{
    partial class ListBoxKontrolu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_sehirListe = new System.Windows.Forms.ListBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.tbx_sehir = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_sehirListe2 = new System.Windows.Forms.ListBox();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birden çok seçenek arasından bir \r\nveya birden çok seçeneği seçmemizi \r\nsağlayan " +
    "yapıdır. ";
            // 
            // lb_sehirListe
            // 
            this.lb_sehirListe.FormattingEnabled = true;
            this.lb_sehirListe.ItemHeight = 16;
            this.lb_sehirListe.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir ",
            "Eskişehir "});
            this.lb_sehirListe.Location = new System.Drawing.Point(41, 160);
            this.lb_sehirListe.Name = "lb_sehirListe";
            this.lb_sehirListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_sehirListe.Size = new System.Drawing.Size(120, 164);
            this.lb_sehirListe.TabIndex = 1;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(41, 333);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 23);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(41, 363);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(93, 16);
            this.lbl_ekran.TabIndex = 3;
            this.lbl_ekran.Text = "Seçilen şehir...";
            // 
            // tbx_sehir
            // 
            this.tbx_sehir.Location = new System.Drawing.Point(41, 131);
            this.tbx_sehir.Name = "tbx_sehir";
            this.tbx_sehir.Size = new System.Drawing.Size(120, 22);
            this.tbx_sehir.TabIndex = 4;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(167, 130);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şehir yazınız:";
            // 
            // lb_sehirListe2
            // 
            this.lb_sehirListe2.FormattingEnabled = true;
            this.lb_sehirListe2.ItemHeight = 16;
            this.lb_sehirListe2.Location = new System.Drawing.Point(248, 160);
            this.lb_sehirListe2.Name = "lb_sehirListe2";
            this.lb_sehirListe2.Size = new System.Drawing.Size(120, 164);
            this.lb_sehirListe2.TabIndex = 7;
            // 
            // btn_aktar
            // 
            this.btn_aktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aktar.Location = new System.Drawing.Point(178, 221);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(55, 32);
            this.btn_aktar.TabIndex = 8;
            this.btn_aktar.Text = ">";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // ListBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.lb_sehirListe2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tbx_sehir);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.lb_sehirListe);
            this.Controls.Add(this.label1);
            this.Name = "ListBoxKontrolu";
            this.Text = "ListBoxKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_sehirListe;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.TextBox tbx_sehir;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_sehirListe2;
        private System.Windows.Forms.Button btn_aktar;
    }
}