namespace WinFormKontrolleri.Northwind
{
    partial class UrunlerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_barkod = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.cb_tedarikci = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_paketleme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.c_satistaMi = new System.Windows.Forms.CheckBox();
            this.btn_kategoriFormAc = new System.Windows.Forms.Button();
            this.btn_tedarikciFormAc = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.nud_guvenlikStok = new System.Windows.Forms.NumericUpDown();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_fiyat);
            this.groupBox1.Controls.Add(this.nud_guvenlikStok);
            this.groupBox1.Controls.Add(this.nud_stok);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.btn_tedarikciFormAc);
            this.groupBox1.Controls.Add(this.btn_kategoriFormAc);
            this.groupBox1.Controls.Add(this.c_satistaMi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_paketleme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_tedarikci);
            this.groupBox1.Controls.Add(this.cb_kategori);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.tb_barkod);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İsim: ";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(66, 36);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(121, 22);
            this.tb_ID.TabIndex = 3;
            // 
            // tb_barkod
            // 
            this.tb_barkod.Location = new System.Drawing.Point(66, 64);
            this.tb_barkod.Name = "tb_barkod";
            this.tb_barkod.Size = new System.Drawing.Size(121, 22);
            this.tb_barkod.TabIndex = 4;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(66, 92);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(121, 22);
            this.tb_isim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori:";
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(309, 36);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(121, 24);
            this.cb_kategori.TabIndex = 7;
            // 
            // cb_tedarikci
            // 
            this.cb_tedarikci.FormattingEnabled = true;
            this.cb_tedarikci.Location = new System.Drawing.Point(309, 66);
            this.cb_tedarikci.Name = "cb_tedarikci";
            this.cb_tedarikci.Size = new System.Drawing.Size(121, 24);
            this.cb_tedarikci.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tedarikçi: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Paketleme: ";
            // 
            // tb_paketleme
            // 
            this.tb_paketleme.Location = new System.Drawing.Point(309, 97);
            this.tb_paketleme.Name = "tb_paketleme";
            this.tb_paketleme.Size = new System.Drawing.Size(121, 22);
            this.tb_paketleme.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stok: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Güvenlik Stoğu: ";
            // 
            // c_satistaMi
            // 
            this.c_satistaMi.AutoSize = true;
            this.c_satistaMi.Location = new System.Drawing.Point(644, 125);
            this.c_satistaMi.Name = "c_satistaMi";
            this.c_satistaMi.Size = new System.Drawing.Size(106, 20);
            this.c_satistaMi.TabIndex = 14;
            this.c_satistaMi.Text = "Satış Devam";
            this.c_satistaMi.UseVisualStyleBackColor = true;
            // 
            // btn_kategoriFormAc
            // 
            this.btn_kategoriFormAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategoriFormAc.Location = new System.Drawing.Point(437, 39);
            this.btn_kategoriFormAc.Name = "btn_kategoriFormAc";
            this.btn_kategoriFormAc.Size = new System.Drawing.Size(36, 23);
            this.btn_kategoriFormAc.TabIndex = 15;
            this.btn_kategoriFormAc.Text = "+";
            this.btn_kategoriFormAc.UseVisualStyleBackColor = true;
            this.btn_kategoriFormAc.Click += new System.EventHandler(this.btn_kategoriFormAc_Click);
            // 
            // btn_tedarikciFormAc
            // 
            this.btn_tedarikciFormAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tedarikciFormAc.Location = new System.Drawing.Point(437, 66);
            this.btn_tedarikciFormAc.Name = "btn_tedarikciFormAc";
            this.btn_tedarikciFormAc.Size = new System.Drawing.Size(36, 23);
            this.btn_tedarikciFormAc.TabIndex = 16;
            this.btn_tedarikciFormAc.Text = "+";
            this.btn_tedarikciFormAc.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(659, 151);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(91, 23);
            this.btn_kaydet.TabIndex = 17;
            this.btn_kaydet.Text = "Ürün Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(602, 69);
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(148, 22);
            this.nud_stok.TabIndex = 18;
            // 
            // nud_guvenlikStok
            // 
            this.nud_guvenlikStok.Location = new System.Drawing.Point(602, 97);
            this.nud_guvenlikStok.Name = "nud_guvenlikStok";
            this.nud_guvenlikStok.Size = new System.Drawing.Size(148, 22);
            this.nud_guvenlikStok.TabIndex = 19;
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(602, 40);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(148, 22);
            this.tb_fiyat.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fiyat: ";
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunlerForm";
            this.Text = "Ürün İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_barkod;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.NumericUpDown nud_guvenlikStok;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_tedarikciFormAc;
        private System.Windows.Forms.Button btn_kategoriFormAc;
        private System.Windows.Forms.CheckBox c_satistaMi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_paketleme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tedarikci;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_isim;
    }
}