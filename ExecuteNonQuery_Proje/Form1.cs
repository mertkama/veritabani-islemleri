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

namespace ExecuteNonQuery_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //KayitEkle();
            KayitEkle_SP(Convert.ToInt32(txtId.Text), txtIsim.Text, txtSoyisim.Text);
            MessageBox.Show("Kaydedildi");
        }


        void KayitEkle()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("INSERT INTO Musteri VALUES (2,'Test Isım','Test Soyisim')", connection);

            connection.Open();

            int etkilenenKayitSayisi = command.ExecuteNonQuery();

            connection.Close();
        }

        void KayitEkleParametre(int id,string ad,string soyad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("INSERT INTO Musteri VALUES (@ID,@ISIM,@SOYISIM)", connection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@ISIM", SqlDbType.NVarChar).Value = ad;
            command.Parameters.Add("@SOYISIM", SqlDbType.NVarChar).Value = soyad;

            connection.Open();

            int etkilenenKayitSayisi = command.ExecuteNonQuery();

            connection.Close();
        }

        void KayitEkle_SP(int id,string ad,string soyad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("SP_Musteri_YeniKayit", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MusteriID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = ad;
            command.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = soyad;

            connection.Open();

            int etkilenenKayitSayisi = command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
