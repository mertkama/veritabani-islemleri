using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=Test;Integrated Security=True;";

            /*SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "Veritabanı İsmi";
            builder.DataSource = "Server";
            builder.UserID = "Sql Kullanıcı";
            builder.Password = "Sql Kullanıcı Sifresi";

            connection.ConnectionString = builder.ConnectionString;*/


                        
            connection.Open();
            Console.WriteLine($"Bağlantı Durumu : {connection.State}");
            connection.Close();
            Console.WriteLine($"Bağlantı Durumu : {connection.State}");



            // App config üzerinden erişim

            System.Data.SqlClient.SqlConnection connectionAppConfig = new System.Data.SqlClient.SqlConnection();

            connectionAppConfig.ConnectionString = ConfigurationManager.ConnectionStrings["SQLCS"].ConnectionString;

            connectionAppConfig.Open();
            Console.WriteLine($"Config Bağlantı Durumu : {connectionAppConfig.State}");
            connectionAppConfig.Close();


            Console.ReadKey();


        }
    }
}
