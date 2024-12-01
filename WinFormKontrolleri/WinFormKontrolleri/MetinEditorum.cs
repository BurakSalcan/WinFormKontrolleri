using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKontrolleri
{
    public partial class MetinEditorum : Form
    {
        string yol = "";
        public MetinEditorum()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Tüm Dosyalar|*.*";
            openFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Tüm Dosyalar|*.*";
            FontFamily[] fontlar = FontFamily.Families;
            foreach (FontFamily item in fontlar)
            {
                TSCB_font.Items.Add(item.Name);
            }
            TSCB_font.SelectedItem = richTextBox1.Font.Name;
            TSCB_size.SelectedItem = "11";
            Font ff = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
            richTextBox1.Font = ff;

        }

        private void TSMI_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_kaydet_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                yol = saveFileDialog1.FileName;
                richTextBox1.SaveFile(yol);
                MessageBox.Show("Kayıt Başarılı", "Kaydedildi");
            }
        }

        private void TSMI_ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);

                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                if (fi.Extension == ".txt")
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string metin = sr.ReadToEnd();
                    richTextBox1.Text = metin;
                }
                else if (fi.Extension == ".rtf")
                {
                    richTextBox1.LoadFile(saveFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Seçilen format uygun değildir.", "HATA");
                }
            }
            else //Dosya seçilmemişse
            {
                MessageBox.Show("Dosya açma işlemi iptal edildi.", "İPTAL");
            }
        }

        private void TSCB_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily ff = new FontFamily(TSCB_font.Text);
            float FontSize = 11;
            if (TSCB_size.SelectedItem != null)
            {
                FontSize = Convert.ToSingle(TSCB_size.SelectedItem.ToString());
            }
            Font seciliFont = new Font(ff, FontSize);
            if (richTextBox1.SelectedText.Length == 0)
            {
                richTextBox1.Font = seciliFont;
            }
            else
            {
                richTextBox1.SelectionFont = seciliFont;
            }
            

            //richTextBox1.Font = seciliFont;
        }

        private void TSCB_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TSCB_font.SelectedItem != null)
            {
                FontFamily ff = new FontFamily(TSCB_font.Text);
                Font seciliFont = new Font(ff, Convert.ToSingle(TSCB_size.SelectedItem.ToString()));
                richTextBox1.Font = seciliFont;
            }
            
        }

        private void TSMI_yazdir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Yazdırma işlemi gerçekleştirildi", "Yazdırıldı");
            }
            else
            {
                MessageBox.Show("Yazdırma işlemi iptal edildi.", "İptal edildi");
            }
        }

        private void TSBTN_fontDegistir_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void TSBTN_renk_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
                TSBTN_renk.ForeColor = colorDialog1.Color;
            }
        }
    }
}
