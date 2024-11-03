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
    public partial class ButtonKontrolu : Form
    {
        public ButtonKontrolu()
        {
            InitializeComponent();
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Text = "HAV HAV HAV HAV";
            btn_tikla.Text = "HAV HAV HAV HAV";
            button1.Text = button2.Text = button3.Text = button4.Text = "HAV HAV HAV HAV";
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(lbl_counter.Text);
            sayi += 1;
            lbl_counter.Text = Convert.ToString(sayi);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
