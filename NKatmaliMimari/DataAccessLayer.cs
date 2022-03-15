using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NKatmaliMimari
{
    public class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;

        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";
        }

        void BaglantiAyarla()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }


        public int MusteriKaydet(Musteri musteri)
        {          

            command = new SqlCommand("INSERT INTO Musteri VALUES (@ID,@ISIM,@SOYISIM)", connect);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = musteri.MusteriId;
            command.Parameters.Add("@ISIM", SqlDbType.NVarChar).Value = musteri.Ad;
            command.Parameters.Add("@SOYISIM", SqlDbType.NVarChar).Value = musteri.Soyad;

            connect.Open();

            int etkilenenKayitSayisi = command.ExecuteNonQuery();

            connect.Close();

            return etkilenenKayitSayisi;
        }


    }
}
