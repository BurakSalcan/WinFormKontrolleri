using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKontrolleri
{
    public partial class CheckBoxRadioButton : Form
    {
        public CheckBoxRadioButton()
        {
            InitializeComponent();
            rbtn_erkek.Checked = true;
            rbtn_evli.Checked = true;
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            //lbl_ekran.Text = cb_secim.Checked.ToString();
            if (cb_secim.Checked)
            {
                lbl_ekran.Text = "Gönderme işlemi başarılı.";
            }
            else
            {
                MessageBox.Show("Sözleşmeyi kabul etmelisiniz", "Sözleşme Kabulü");
            }
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            string diller = "";

            if (cb_ingilizce.Checked) {  diller += " İngilizce"; }
            if (cb_almanca.Checked) { diller += " Almanca"; }
            if (cb_swahilce.Checked)  { diller += " Swahilce"; }

            lbl_ekran2.Text = "Diller= " + diller;

            string cinsiyet = "Erkek";
            if(rbtn_kadin.Checked)
            {
                cinsiyet = "Kadın";
            }

            string medeniDurum = "Evli";
            if(rbtn_evli.Checked)
            {
                medeniDurum = "Bekar";
            }

            lbl_ekran3.Text = "Cinsiyet= " + cinsiyet + "\n" + "Medeni Durum= " + medeniDurum;
        }
    }
}
