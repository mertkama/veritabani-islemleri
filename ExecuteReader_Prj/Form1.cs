using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecuteReader_Prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //GetirParametre(3);
            GetirSp();
        }

        void Getir()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("SELECT * FROM Musteri", connection);
                      


            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            int musteriId = 0;
            string ad = "";
            string soyad = "";

            while (reader.Read())
            {
                musteriId =(int) reader[0];
                ad = reader["Isim"].ToString();
                soyad = reader.GetString(2);
            }

            reader.Close();

            connection.Close();


            label1.Text = musteriId.ToString() + " " + ad + " " + soyad;
        }

        void GetirParametre(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("SELECT * FROM Musteri WHERE MusteriId=@ID", connection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;


            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            int musteriId = 0;
            string ad = "";
            string soyad = "";

            while (reader.Read())
            {
                musteriId = (int)reader[0];
                ad = reader["Isim"].ToString();
                soyad = reader.GetString(2);
            }

            reader.Close();

            connection.Close();


            label1.Text = musteriId.ToString() + " " + ad + " " + soyad;
        }

        void GetirSp()
        {
            List<Musteri> musteriListesi = new List<Musteri>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("SP_Musteri_Liste", connection);
            command.CommandType = CommandType.StoredProcedure;


            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

          

            while (reader.Read())
            {
                musteriListesi.Add(new Musteri {
                    MusteriId= (int)reader[0],
                    Ad= reader["Isim"].ToString(),
                    Soyad= reader.GetString(2)
                });               
            }

            foreach (var item in musteriListesi)
            {
                listBox1.Items.Add(item.MusteriId + " " + item.Ad + " " + item.Soyad);
            }

            reader.Close();

            connection.Close();
        }
    }
}
