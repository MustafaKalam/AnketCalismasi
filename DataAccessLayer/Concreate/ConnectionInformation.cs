using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concreate;

namespace DataAccessLayer
{
    public class ConnectionInformation
    {
        SqlConnection sqlConnection = new SqlConnection(@"server=192.168.1.150\SQL2014; initial catalog=RecapDemo; user id=sa; Password=Acilim@2015;");
        private string _message;

        public List<FirmaBilgileri> FirmaDoldur()
        {
            ConnectionControl();

            string query = "SELECT ID, FirmaKodu, FirmaAdi FROM FirmaBilgileri";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<FirmaBilgileri> firmas = new List<FirmaBilgileri>();
            while (reader.Read())
            {
                FirmaBilgileri firmaBilgileri = new FirmaBilgileri
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    FirmaKodu = reader["FirmaKodu"].ToString(),
                    FirmaAdi = reader["FirmaAdi"].ToString()
                };
                firmas.Add(firmaBilgileri);
            }
            reader.Close();
            sqlConnection.Close();
            return firmas;
        }

        public void ConnectionControl()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public string KullaniciGirisKontrol(string FirmaId, string KullaniciAdi, string Sifre)
        {
            ConnectionControl();
            string query = "SELECT COUNT(1) AS nKayitSayisi FROM KullaniciBilgileri a WHERE a.FirmaID=@FirmaID AND a.KullaniciAdi=@KullaniciAdi AND a.Sifre=@Sifre ";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@FirmaID", FirmaId);
            command.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            command.Parameters.AddWithValue("@Sifre", Sifre);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (Convert.ToInt32(reader["nKayitSayisi"]) > 0)
                {
                    _message = "GirisBasarili";
                }
                else
                {
                    _message = "GirisBasarisiz";
                }
            }
            else
            {
                _message = "GirisBasarisiz";
            }
            return _message;
        }
    }
}
