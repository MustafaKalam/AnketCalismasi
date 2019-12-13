using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class frmSube : Form
    {
        public frmSube()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtAdi.Text = "";
            txtSubeMarketKodu.Text = "";
            cmbBolgesi.Text = "";
        }
        public void gorunur()
        {
            txtAdi.Enabled = true;
            txtSubeMarketKodu.Enabled = true;
            cmbBolgesi.Enabled = true;
            
        }
        public void gorunmez()
        {
            txtAdi.Enabled = false;
            txtSubeMarketKodu.Enabled = false;
            cmbBolgesi.Enabled = false;
            
        }
        private void frmSube_Load(object sender, EventArgs e)
        {
            gorunmez();
        }

        private void eKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gorunmez();
            gorunur();
            btnEkle.Enabled = true;
            temizle();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gorunmez();
            txtSubeMarketKodu.Enabled = true;
            btnListele.Enabled = true;
            temizle();
        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gorunmez();
        }
    }
}
