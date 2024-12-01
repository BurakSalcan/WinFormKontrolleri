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
    public partial class MDIIcinAnaForm : Form
    {
        public MDIIcinAnaForm()
        {
            InitializeComponent();
        }

        private void TSMI_metinAraclari_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach(Form form in acikFormlar)
            {
                if(form.GetType() == typeof(MetinAraclari))
                {
                    acikMi = true;
                    form.Activate();//Form Açılmışsa En Öne Getir
                }
            }
            if(acikMi == false)
            {
                MetinAraclari frm = new MetinAraclari();
                frm.MdiParent = this;
                frm.Show();
            }

              
        }

        private void TSMI_MetinEditorumAc_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(MetinEditorum))
                {
                    acikMi = true;
                    form.Activate();//Form Açılmışsa En Öne Getir
                }
            }
            if (acikMi == false)
            {
                MetinEditorum frm = new MetinEditorum();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
