using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaglantiBilgisi
{
    public class DataAccessLayer
    {
        System.Data.SqlClient.SqlConnection connect;

        public DataAccessLayer(string dataSource,string initialCatalog,string kullaniciAdi,string sifre)
        {
            connect = new System.Data.SqlClient.SqlConnection();
            connect.ConnectionString = BaglantıCumlesi_Olustur(dataSource, initialCatalog, kullaniciAdi, sifre);
        }

        string BaglantıCumlesi_Olustur(string dataSource, string initialCatalog, string kullaniciAdi, string sifre)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = dataSource;
            builder.InitialCatalog = initialCatalog;
            /*builder.UserID = kullaniciAdi;
            builder.Password = sifre;*/

            return builder.ConnectionString;
        }

        public void BaglantiDurumYonetimi()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }


        public System.Data.ConnectionState BaglantiDurumBilgisi()
        {
            return connect.State;
        }
    }
}
