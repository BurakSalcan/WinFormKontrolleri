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
    public partial class DateTimeKontrolleri : Form
    {
        public DateTimeKontrolleri()
        {
            InitializeComponent();
            mc_takvim.MaxSelectionCount = 10; //Takvimde günleri seçerken max sayıyı belirler.
            //mc_takvim.ShowToday = false; //Takvimin altındaki mevcut günü kaldırır.
            //mc_takvim.ShowTodayCircle = false;
            mc_takvim.ShowWeekNumbers = true; //Takvimde kaçıncı haftada olduğumuzu gösterir.

        }

        private void btn_tarihGetir_Click(object sender, EventArgs e)
        {
            DateTime secilen = dtp_dogum.Value;

            //string saat = nud_saat.Value.ToString();
            int saat = Convert.ToInt32(nud_saat.Value);
            int dakika = Convert.ToInt32(nud_dakika.Value);

            lbl_tarih.Text = secilen.ToString(); //Tarih + Saat
            lbl_kisaTarih.Text = secilen.ToShortDateString(); //Sadece Tarih
            lbl_uzunTarih.Text = secilen.ToLongDateString(); //Tarih + Gün

            DateTime uretilen = Convert.ToDateTime(secilen.ToShortDateString() + " " + saat + ":" + dakika + ":00");
            MessageBox.Show("Üretilen: " + uretilen.ToString());
            lbl_uretilen.Text = uretilen.ToString();
        }

        private void btn_aralik_Click(object sender, EventArgs e)
        {

            string aralik = mc_takvim.SelectionStart.ToShortDateString() + " - " + mc_takvim.SelectionEnd.ToShortDateString();
            lbl_aralik.Text = aralik;

            TimeSpan ts = mc_takvim.SelectionEnd - mc_takvim.SelectionStart;
            int gun = Convert.ToInt32(ts.TotalDays);
            lbl_tarihFarki.Text = gun.ToString();
        }
    }
}
