namespace WinFormKontrolleri
{
    partial class ButtonKontrolu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_tikla = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Button();
            this.lbl_buttonHaha = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Standart Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(164, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Şişman \r\nButton";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(485, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Renkli \r\nButton";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_tikla
            // 
            this.btn_tikla.AutoSize = true;
            this.btn_tikla.Location = new System.Drawing.Point(670, 98);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(75, 26);
            this.btn_tikla.TabIndex = 4;
            this.btn_tikla.Text = "Tıkla";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // lbl_counter
            // 
            this.lbl_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_counter.Location = new System.Drawing.Point(682, 401);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(131, 56);
            this.lbl_counter.TabIndex = 6;
            this.lbl_counter.Text = "0";
            this.lbl_counter.UseVisualStyleBackColor = true;
            this.lbl_counter.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbl_buttonHaha
            // 
            this.lbl_buttonHaha.BackgroundImage = global::WinFormKontrolleri.Properties.Resources.WhatsApp_Image_2024_08_01_at_10_29_44;
            this.lbl_buttonHaha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lbl_buttonHaha.Location = new System.Drawing.Point(640, 193);
            this.lbl_buttonHaha.Name = "lbl_buttonHaha";
            this.lbl_buttonHaha.Size = new System.Drawing.Size(208, 202);
            this.lbl_buttonHaha.TabIndex = 5;
            this.lbl_buttonHaha.UseVisualStyleBackColor = true;
            this.lbl_buttonHaha.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackgroundImage = global::WinFormKontrolleri.Properties.Resources.WhatsApp_Image_2024_11_03_at_16_22_34;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(63, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(520, 393);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButtonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1097, 660);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.lbl_buttonHaha);
            this.Controls.Add(this.btn_tikla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ButtonKontrolu";
            this.Text = "ButtonKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_tikla;
        private System.Windows.Forms.Button lbl_buttonHaha;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button lbl_counter;
    }
}