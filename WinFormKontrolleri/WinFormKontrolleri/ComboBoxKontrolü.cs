using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKontrolleri.Model;

namespace WinFormKontrolleri
{
    
    public partial class ComboBoxKontrolü : Form
    {
        List<Marka> markalar = new List<Marka>();
        public ComboBoxKontrolü()
        {
            InitializeComponent();
            markalar.Add(new Marka() { ID = 1, Isim = "Bosch" });
            markalar.Add(new Marka() { ID = 2, Isim = "Arçelik" });
            markalar.Add(new Marka() { ID = 3, Isim = "Siemens" });
            markalar.Add(new Marka() { ID = 4, Isim = "Vestel" });

            cb_markalar.ValueMember = "ID";
            cb_markalar.DisplayMember = "Isim";
            cb_markalar.DataSource = markalar;
        }

        private void btn_departmanSec_Click(object sender, EventArgs e)
        {
            //string secilen = cb_departman.SelectedItem.ToString();
            string secilen = cb_departman.Text;
            if (secilen != "Seçiniz...")
            {
                lbl_secilenDepartman.Text = secilen;
            }
            else
            {
                lbl_secilenDepartman.Text = "Lütfen seçim yapınız.";
            }
            
            
            
        }

        private void cb_eğitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_egitim.SelectedItem.ToString();
            lbl_eğitim.Text = secilen;
        }

        private void btn_markaSeç_Click(object sender, EventArgs e)
        {
            //string secilen = "ID = " + cb_markalar.SelectedValue.ToString();
            //secilen += "Isim = " + cb_markalar.SelectedItem.ToString();

            Marka m = (Marka)cb_markalar.SelectedItem;

            lbl_marka.Text = "ID = " + m.ID + " / Isim = " + m.Isim;
        }
    }
}
