namespace WinFormKontrolleri
{
    partial class MessageBoxKontrolü
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
            this.btn_standart = new System.Windows.Forms.Button();
            this.btn_evetHayir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_dene = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_warning = new System.Windows.Forms.Button();
            this.btn_error = new System.Windows.Forms.Button();
            this.btn_question = new System.Windows.Forms.Button();
            this.btn_formAc = new System.Windows.Forms.Button();
            this.btn_sistem = new System.Windows.Forms.Button();
            this.btn_formAc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_standart
            // 
            this.btn_standart.Location = new System.Drawing.Point(12, 12);
            this.btn_standart.Name = "btn_standart";
            this.btn_standart.Size = new System.Drawing.Size(182, 32);
            this.btn_standart.TabIndex = 0;
            this.btn_standart.Text = "Standart Message Box";
            this.btn_standart.UseVisualStyleBackColor = true;
            this.btn_standart.Click += new System.EventHandler(this.btn_standart_Click);
            // 
            // btn_evetHayir
            // 
            this.btn_evetHayir.Location = new System.Drawing.Point(13, 51);
            this.btn_evetHayir.Name = "btn_evetHayir";
            this.btn_evetHayir.Size = new System.Drawing.Size(181, 31);
            this.btn_evetHayir.TabIndex = 1;
            this.btn_evetHayir.Text = "Sana bir sorum var gııız :) ";
            this.btn_evetHayir.UseVisualStyleBackColor = true;
            this.btn_evetHayir.Click += new System.EventHandler(this.btn_evetHayir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_dene
            // 
            this.btn_dene.Location = new System.Drawing.Point(13, 126);
            this.btn_dene.Name = "btn_dene";
            this.btn_dene.Size = new System.Drawing.Size(181, 29);
            this.btn_dene.TabIndex = 3;
            this.btn_dene.Text = "Dene";
            this.btn_dene.UseVisualStyleBackColor = true;
            this.btn_dene.Click += new System.EventHandler(this.btn_dene_Click);
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(13, 162);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(181, 27);
            this.btn_abort.TabIndex = 4;
            this.btn_abort.Text = "Görev Başarısı";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(248, 12);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(126, 31);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "İnfo";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_warning
            // 
            this.btn_warning.Location = new System.Drawing.Point(248, 51);
            this.btn_warning.Name = "btn_warning";
            this.btn_warning.Size = new System.Drawing.Size(126, 31);
            this.btn_warning.TabIndex = 6;
            this.btn_warning.Text = "Warning";
            this.btn_warning.UseVisualStyleBackColor = true;
            this.btn_warning.Click += new System.EventHandler(this.btn_warning_Click);
            // 
            // btn_error
            // 
            this.btn_error.Location = new System.Drawing.Point(248, 89);
            this.btn_error.Name = "btn_error";
            this.btn_error.Size = new System.Drawing.Size(126, 29);
            this.btn_error.TabIndex = 7;
            this.btn_error.Text = "Error";
            this.btn_error.UseVisualStyleBackColor = true;
            this.btn_error.Click += new System.EventHandler(this.btn_error_Click);
            // 
            // btn_question
            // 
            this.btn_question.Location = new System.Drawing.Point(248, 126);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(126, 29);
            this.btn_question.TabIndex = 8;
            this.btn_question.Text = "Soru";
            this.btn_question.UseVisualStyleBackColor = true;
            this.btn_question.Click += new System.EventHandler(this.btn_question_Click);
            // 
            // btn_formAc
            // 
            this.btn_formAc.Location = new System.Drawing.Point(428, 12);
            this.btn_formAc.Name = "btn_formAc";
            this.btn_formAc.Size = new System.Drawing.Size(238, 31);
            this.btn_formAc.TabIndex = 9;
            this.btn_formAc.Text = "MetinAraclariKontrolleri Formunu Aç";
            this.btn_formAc.UseVisualStyleBackColor = true;
            this.btn_formAc.Click += new System.EventHandler(this.btn_formAc_Click);
            // 
            // btn_sistem
            // 
            this.btn_sistem.Location = new System.Drawing.Point(428, 51);
            this.btn_sistem.Name = "btn_sistem";
            this.btn_sistem.Size = new System.Drawing.Size(238, 30);
            this.btn_sistem.TabIndex = 10;
            this.btn_sistem.Text = "Sistem Programlarını Aç";
            this.btn_sistem.UseVisualStyleBackColor = true;
            this.btn_sistem.Click += new System.EventHandler(this.btn_sistem_Click);
            // 
            // btn_formAc2
            // 
            this.btn_formAc2.Location = new System.Drawing.Point(428, 89);
            this.btn_formAc2.Name = "btn_formAc2";
            this.btn_formAc2.Size = new System.Drawing.Size(238, 66);
            this.btn_formAc2.TabIndex = 11;
            this.btn_formAc2.Text = "MetinAraclariKontrolleri \r\nFormunu Aç - Dialog";
            this.btn_formAc2.UseVisualStyleBackColor = true;
            this.btn_formAc2.Click += new System.EventHandler(this.btn_formAc2_Click);
            // 
            // MessageBoxKontrolü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_formAc2);
            this.Controls.Add(this.btn_sistem);
            this.Controls.Add(this.btn_formAc);
            this.Controls.Add(this.btn_question);
            this.Controls.Add(this.btn_error);
            this.Controls.Add(this.btn_warning);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.btn_dene);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_evetHayir);
            this.Controls.Add(this.btn_standart);
            this.Name = "MessageBoxKontrolü";
            this.Text = "MessageBoxKontrolü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_standart;
        private System.Windows.Forms.Button btn_evetHayir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_dene;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_warning;
        private System.Windows.Forms.Button btn_error;
        private System.Windows.Forms.Button btn_question;
        private System.Windows.Forms.Button btn_formAc;
        private System.Windows.Forms.Button btn_sistem;
        private System.Windows.Forms.Button btn_formAc2;
    }
}