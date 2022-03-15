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

namespace ExecuteScalar_Prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetirSP(5);
        }

        void MusteriIsmiGetir()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("SELECT Isim from Musteri Where MusteriId=3", connection);


            connection.Open();

            string isim = command.ExecuteScalar().ToString();

            connection.Close();

            label1.Text = isim;
        }

        void MusteriIsmiGetirParametre(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("SELECT Isim from Musteri Where MusteriId=@ID", connection);

            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;


            connection.Open();

            string isim = command.ExecuteScalar().ToString();

            connection.Close();

            label1.Text = isim;
        }


        void MusteriGetirSP(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=AdoNet;Integrated Security=True;";

            SqlCommand command = new SqlCommand("SP_Musteri_Isim_Getir", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MusteriID", SqlDbType.Int).Value = id;


            connection.Open();

            string isim = command.ExecuteScalar().ToString();

            connection.Close();

            label1.Text = isim;

        }
    }
}
