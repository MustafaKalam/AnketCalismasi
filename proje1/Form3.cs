using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje1
{
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"server=192.168.1.150\SQL2014; initial catalog=RecapDemo; user id=sa; Password=Acilim@2015;");
        string cinsiyet;
        public void temizle()
        {
            txtAdi.Text = "";
            txtPersonelKodu.Text = "";
            txtSoyadi.Text = "";
            txtTC.Text = "";
            txtSifresi.Text = "";
            cmbBolgesi.Text = "";
            checkErkek.Checked = false;
            checkKadin.Checked = false;
        }
        public void gorunur()
        {

            txtAdi.Enabled = true;
            txtPersonelKodu.Enabled = true;
            txtSifresi.Enabled = true;
            txtSoyadi.Enabled = true;
            txtTC.Enabled = true;
            cmbBolgesi.Enabled = true;
            checkErkek.Enabled = true;
            checkKadin.Enabled = true;

        }
        public void gorunmez()
        {

            txtAdi.Enabled = false;
            txtPersonelKodu.Enabled = false;
            txtSifresi.Enabled = false;
            txtSoyadi.Enabled = false;
            txtTC.Enabled = false;
            cmbBolgesi.Enabled = false;
            checkErkek.Enabled = false;
            checkKadin.Enabled = false;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = false;
            btnListele.Enabled = false;
            btnSil.Enabled = false;
            groupBox1.Enabled = false;
            btnListele.Enabled = false;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtPersonelKodu.Text == "" || txtSifresi.Text == "" || cmbBolgesi.Text == "" || checkErkek.Checked == false && checkKadin.Checked == false)
            {
                MessageBox.Show("Boş alan bırakmayınız");

            }
            else
            {
                sqlConnection.Open();
                SqlCommand arama = new SqlCommand("select * from yonetici where tc=" + txtTC.Text + "", sqlConnection);
                SqlDataReader oku = arama.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu TC numarasına ait yönetici bulunmakta");
                }
                else
                {
                    oku.Close();
                    SqlCommand ekle = new SqlCommand("insert into yonetici(TC,Adi,Soyadi,PersonelKodu,Sifre,Bolge,Cinsiyet) values(@k1,@k2,@k3,@k4,@k5,@k6,@k7) ", sqlConnection);
                    ekle.Parameters.AddWithValue("@k1", Convert.ToInt64(txtTC.Text));
                    ekle.Parameters.AddWithValue("@k2", txtAdi.Text);
                    ekle.Parameters.AddWithValue("@k3", txtSoyadi.Text);
                    ekle.Parameters.AddWithValue("@k4", txtPersonelKodu.Text);
                    ekle.Parameters.AddWithValue("@k5", txtSifresi.Text);
                    ekle.Parameters.AddWithValue("@k6", cmbBolgesi.Text);
                    if (checkErkek.Checked == true)
                    {
                        cinsiyet = "Erkek";
                        ekle.Parameters.AddWithValue("@k7", cinsiyet);
                    }
                    else
                    {
                        cinsiyet = "Kadın";
                        ekle.Parameters.AddWithValue("@k7", cinsiyet);
                    }
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı");
                }
                sqlConnection.Close();
                temizle();
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("aaa");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (txtTC.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz Yöneticinin TC Numarasını Giriniz");
            }
            else
            {
                SqlCommand arama = new SqlCommand("select * from yonetici where tc=" + txtTC.Text + "", sqlConnection);
                SqlDataReader oku = arama.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    SqlCommand sil = new SqlCommand("delete from yonetici where tc=@k1", sqlConnection);
                    sil.Parameters.AddWithValue("@k1", Convert.ToInt64(txtTC.Text));
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Bu TC numarasına ait Yönetici bulunmamakta");
                }


            }
            sqlConnection.Close();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtPersonelKodu.Text == "" || txtSifresi.Text == "" || cmbBolgesi.Text == "" || checkErkek.Checked == false && checkKadin.Checked == false)
            {
                MessageBox.Show("Boş alan bırakmayınız");

            }
            else
            {
                sqlConnection.Open();
                SqlCommand arama = new SqlCommand("select * from yonetici where tc=" + txtTC.Text + "", sqlConnection);
                SqlDataReader oku = arama.ExecuteReader();
                if (oku.Read())
                {
                    oku.Close();
                    SqlCommand ekle = new SqlCommand("update yonetici set Adi=@k2,Soyadi=@k3,PersonelKodu=@k4,Sifre=@k5,Bolge=@k6,Cinsiyet=@k7 where TC=@k1 ", sqlConnection);
                    ekle.Parameters.AddWithValue("@k1", Convert.ToInt64(txtTC.Text));
                    ekle.Parameters.AddWithValue("@k2", txtAdi.Text);
                    ekle.Parameters.AddWithValue("@k3", txtSoyadi.Text);
                    ekle.Parameters.AddWithValue("@k4", txtPersonelKodu.Text);
                    ekle.Parameters.AddWithValue("@k5", txtSifresi.Text);
                    ekle.Parameters.AddWithValue("@k6", cmbBolgesi.Text);
                    if (checkErkek.Checked == true)
                    {
                        cinsiyet = "Erkek";
                        ekle.Parameters.AddWithValue("@k7", cinsiyet);
                    }
                    else
                    {
                        cinsiyet = "Kadın";
                        ekle.Parameters.AddWithValue("@k7", cinsiyet);
                    }
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Güncellemek istediğiniz Yönetici bulunmamakta");
                }

            }
            sqlConnection.Close();
            temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            if (rndTc.Checked == true)
            {
                if (txtTC.Text == "")
                {
                    MessageBox.Show("TC alanını boş bırakmayın");
                    txtTC.Focus();

                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where TC=" + txtTC.Text + "", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                temizle();

            }
            else if (rndSifresi.Checked == true)
            {

                if (txtSifresi.Text == "")
                {
                    MessageBox.Show("Şifre alanını boş bırakmayın");
                    txtSifresi.Focus();

                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where Sifre='" + txtSifresi.Text + "'", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                temizle();

            }
            else if (rndAd.Checked == true)
            {

                if (txtAdi.Text == "")
                {
                    MessageBox.Show("Ad alanını boş bırakmayın");
                    txtAdi.Focus();

                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where Adi='" + txtAdi.Text + "'", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                temizle();


            }
            else if (rndSoyad.Checked == true)
            {

                if (txtSoyadi.Text == "")
                {
                    MessageBox.Show("Soyad alanını boş bırakmayın");
                    txtSoyadi.Focus();

                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where Soyadi='" + txtSoyadi.Text + "'", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                temizle();
            }



            else if (rndPersonelKodu.Checked == true)
            {

                if (rndPersonelKodu.Text == "")
                {
                    MessageBox.Show("Personel Kodu alanını boş bırakmayın");
                    rndPersonelKodu.Focus();

                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where PersonelKodu='" + txtPersonelKodu.Text + "'", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                temizle();
            }
            else if (rndBolgesi.Checked == true)
            {

                if (cmbBolgesi.Text == "")
                {
                    MessageBox.Show("Bölge alanını boş bırakmayın");
                    cmbBolgesi.Focus();

                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where Bolge='" + cmbBolgesi.Text + "'", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                temizle();
            }
            else if (rndCinsiyet.Checked == true)
            {

                if (checkErkek.Checked == false && checkKadin.Checked == false)
                {
                    MessageBox.Show("Cinsiyet alanını boş bırakmayın");


                }
                else if (checkErkek.Checked == true)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where Cinsiyet='Erkek'", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from yonetici where Cinsiyet='Kadın'", sqlConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                temizle();
            }



            sqlConnection.Close();
        }

        private void rndTc_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                txtTC.Enabled = true;
            }
            else
            {
                txtTC.Enabled = false;
            }
        }



        private void rndAd_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                txtAdi.Enabled = true;
            }
            else
            {
                txtAdi.Enabled = false;
            }
        }

        private void rndSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                txtSoyadi.Enabled = true;
            }
            else
            {
                txtSoyadi.Enabled = false;
            }
        }

        private void rndPersonelKodu_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                txtPersonelKodu.Enabled = true;
            }
            else
            {
                txtPersonelKodu.Enabled = false;
            }
        }

        private void rndSifresi_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                txtSifresi.Enabled = true;
            }
            else
            {
                txtSifresi.Enabled = false;
            }
        }

        private void rndBolgesi_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                cmbBolgesi.Enabled = true;
            }
            else
            {
                cmbBolgesi.Enabled = false;
            }
        }

        private void rndCinsiyet_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                checkErkek.Enabled = true;
                checkKadin.Enabled = true;
            }
            else
            {
                checkErkek.Enabled = false;
                checkKadin.Enabled = false;
            }
        }

        private void checkErkek_CheckedChanged(object sender, EventArgs e)
        {
            checkKadin.Checked = false;
        }

        private void checkKadın_CheckedChanged(object sender, EventArgs e)
        {
            checkErkek.Checked = false;
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
           
            txtTC.Enabled = true;
            


            
            btnSil.Enabled = true;

            temizle();
        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gorunmez();
           

            gorunur();
            btnGuncelle.Enabled = true;

            temizle();
        }

        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gorunmez();

            rndTc.Checked = false;
            rndSoyad.Checked = false;
            rndSifresi.Checked = false;
            rndPersonelKodu.Checked = false;
            rndCinsiyet.Checked = false;
            rndBolgesi.Checked = false;
            rndAd.Checked = false;
            groupBox1.Enabled = true;
            btnListele.Enabled = true;
           




            temizle();
        }




        private void hAKKIMIZDAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Burak Ercan ve Mustafa Kalam tarafından yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenu a = new frmMenu();
            a.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kIRMIZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void sARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void mAVİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void mORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void bEYAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {
            gorunmez();
        }
    }
}
