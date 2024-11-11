namespace WinFormKontrolleri
{
    partial class CheckedListBoxKontrolü
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
            this.clb_diller = new System.Windows.Forms.CheckedListBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clb_diller
            // 
            this.clb_diller.BackColor = System.Drawing.Color.NavajoWhite;
            this.clb_diller.FormattingEnabled = true;
            this.clb_diller.Items.AddRange(new object[] {
            "Almanca",
            "Rusça",
            "Çince",
            "Korece",
            "Japonca",
            "Danca"});
            this.clb_diller.Location = new System.Drawing.Point(6, 33);
            this.clb_diller.Name = "clb_diller";
            this.clb_diller.Size = new System.Drawing.Size(154, 140);
            this.clb_diller.TabIndex = 0;
            // 
            // btn_getir
            // 
            this.btn_getir.BackColor = System.Drawing.Color.MistyRose;
            this.btn_getir.Location = new System.Drawing.Point(166, 33);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 23);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = false;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(171, 63);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran.TabIndex = 3;
            this.lbl_ekran.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Salmon;
            this.groupBox1.Controls.Add(this.clb_diller);
            this.groupBox1.Controls.Add(this.lbl_ekran);
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Location = new System.Drawing.Point(52, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilinen Diller";
            // 
            // CheckedListBoxKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckedListBoxKontrolü";
            this.Text = "CheckedListBoxKontrolü";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_diller;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}