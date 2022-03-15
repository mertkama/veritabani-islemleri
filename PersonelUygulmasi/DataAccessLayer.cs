using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PersonelUygulmasi
{
    public class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;


        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        }


        public void BaglantiAyarlar()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }

        public int SistemGirisKontrol(SistemKullanici kullanici)
        {
            int sonuc = 0;
            try
            {
                command = new SqlCommand("SP_SistemKullanici_Kontrol", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@KullaniciAd", System.Data.SqlDbType.NVarChar).Value = kullanici.KullaniciAdi;
                command.Parameters.Add("@Sifre",System.Data.SqlDbType.NVarChar).Value=kullanici.Sifre;
                BaglantiAyarlar();
                sonuc = (int)command.ExecuteScalar();
                
            }
            catch (Exception)
            {

                //log
            }
            finally
            {
                BaglantiAyarlar();
            }

            return sonuc;
        }

        public int Personel_Ekle(Personel p)
        {
            int sonuc = 0;
            try
            {
                command = new SqlCommand("SP_Personel_Ekle", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@PersonelID", System.Data.SqlDbType.UniqueIdentifier).Value = p.PersonelId;
                command.Parameters.Add("@Isim", System.Data.SqlDbType.NVarChar).Value = p.Isim;
                command.Parameters.Add("@Soyisim", System.Data.SqlDbType.NVarChar).Value = p.Soyisim;
                command.Parameters.Add("@EmailAdres", System.Data.SqlDbType.NVarChar).Value = p.EmailAddres;
                command.Parameters.Add("@TelefonNumarasi", System.Data.SqlDbType.NVarChar).Value = p.Telefon;

                BaglantiAyarlar();

                sonuc = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                // log
            }
            finally
            {
                BaglantiAyarlar();
            }

            return sonuc;
        }


        public SqlDataReader PersonelTumListe()
        {
            command = new SqlCommand("SP_Personeller_Getir", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            BaglantiAyarlar();

            return command.ExecuteReader();
        }

        public SqlDataReader PersonelGetir(Guid id)
        {
            command = new SqlCommand("SP_Personeller_ID_Getir",connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("@PersonelId", System.Data.SqlDbType.UniqueIdentifier).Value = id;

            BaglantiAyarlar();
            return command.ExecuteReader();
        }

        public int PersonelGuncelle(Personel personel)
        {

            int sonuc = 0;

            try
            {
                command = new SqlCommand("SP_Personel_Duzenle", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@PersonelId", System.Data.SqlDbType.UniqueIdentifier).Value = personel.PersonelId;
                command.Parameters.Add("@Isim", System.Data.SqlDbType.NVarChar).Value = personel.Isim;
                command.Parameters.Add("@Soyisim", System.Data.SqlDbType.NVarChar).Value = personel.Soyisim;
                command.Parameters.Add("@EmailAdres", System.Data.SqlDbType.NVarChar).Value = personel.EmailAddres;
                command.Parameters.Add("@TelefonNumarasi", System.Data.SqlDbType.NVarChar).Value = personel.Telefon;
                BaglantiAyarlar();

                sonuc = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                //log
            }
            finally
            {
                BaglantiAyarlar();
            }

            return sonuc;
        }


        public int PersonelSil(Guid id)
        {

            int sonuc = 0;

            try
            {
                command = new SqlCommand("SP_Personel_Sil", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@PersonelId", System.Data.SqlDbType.UniqueIdentifier).Value = id;

                BaglantiAyarlar();

                sonuc = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                BaglantiAyarlar();
            }

            return sonuc;
        }
    }
}
