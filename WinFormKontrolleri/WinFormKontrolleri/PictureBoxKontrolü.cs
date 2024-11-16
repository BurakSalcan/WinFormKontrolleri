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
    public partial class PictureBoxKontrolü : Form
    {
        public PictureBoxKontrolü()
        {
            InitializeComponent();
            pb_resim.ImageLocation = "../../Resimler/ŞüpheliKöpke.jpeg";
            pb_resim.SizeMode = PictureBoxSizeMode.Zoom;
            cb_sizeMode.SelectedIndex = 1;
        }

        private void cb_sizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_sizeMode.SelectedItem.ToString();
            switch (secilen)
            {
                case "Normal":
                    pb_resim.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Resmi Sığdır":
                    pb_resim.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "Resmi Esnet":
                    pb_resim.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Resmi Ortala":
                    pb_resim.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                default:
                    break;
            }
        }
    }
}
