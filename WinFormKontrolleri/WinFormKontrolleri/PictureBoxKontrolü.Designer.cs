namespace WinFormKontrolleri
{
    partial class PictureBoxKontrolü
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
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.cb_sizeMode = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_sizeMode);
            this.groupBox1.Controls.Add(this.pb_resim);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // pb_resim
            // 
            this.pb_resim.Location = new System.Drawing.Point(6, 21);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(298, 207);
            this.pb_resim.TabIndex = 0;
            this.pb_resim.TabStop = false;
            // 
            // cb_sizeMode
            // 
            this.cb_sizeMode.FormattingEnabled = true;
            this.cb_sizeMode.Items.AddRange(new object[] {
            "Normal",
            "Resmi Sığdır",
            "Resmi Esnet",
            "Resmi Ortala"});
            this.cb_sizeMode.Location = new System.Drawing.Point(7, 234);
            this.cb_sizeMode.Name = "cb_sizeMode";
            this.cb_sizeMode.Size = new System.Drawing.Size(205, 24);
            this.cb_sizeMode.TabIndex = 1;
            this.cb_sizeMode.SelectedIndexChanged += new System.EventHandler(this.cb_sizeMode_SelectedIndexChanged);
            // 
            // PictureBoxKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 391);
            this.Controls.Add(this.groupBox1);
            this.Name = "PictureBoxKontrolü";
            this.Text = "PictureBoxKontrolü";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.ComboBox cb_sizeMode;
    }
}