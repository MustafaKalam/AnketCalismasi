using DataAccessLayer;
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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FirmaBilgileriDoldur();
        }

        private void FirmaBilgileriDoldur()
        {
            ConnectionInformation connection = new ConnectionInformation();
            cmbFirma.DataSource = connection.FirmaDoldur();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Lütfen Kullanici Adı Giriniz");
                txtKullaniciAdi.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen Şifre Giriniz");
                txtSifre.Focus();
                return;
            }
            if (KullaniciKontrol(cmbFirma.SelectedValue.ToString(), txtKullaniciAdi.Text, txtSifre.Text))
            {
                frmMenu frm2 = new frmMenu();
                this.Hide();
                frm2.Show();
            } 
        }

        private bool KullaniciKontrol(string FirmaID, string KullaniciAdi, string Sifre)
        {
            ConnectionInformation information = new ConnectionInformation();
            string result = information.KullaniciGirisKontrol(FirmaID,KullaniciAdi,Sifre);
            if (result== "GirisBasarili")
            {
                MessageBox.Show("Giriş İşlemi Başarılı.");
                return true;
            }
            else
            {
                MessageBox.Show("Giriş İşlemi Başarısız.");
                return false;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
