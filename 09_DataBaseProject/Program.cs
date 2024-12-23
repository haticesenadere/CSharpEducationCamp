using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("****** C# Veri Tabanlı Ürün-Kategori Bilgi Sistmei ");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Lütfen Getirmek istediğiniz tablo numarasını giriniz:");
            tableNumber = Console.ReadLine();


            SqlConnection connection = new SqlConnection
            ("Data Source=DESKTOP-B261NU2\\MSSQLSERVER02;initial Catalog=EducationCampDb;integrated Security=true;");
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
               foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
