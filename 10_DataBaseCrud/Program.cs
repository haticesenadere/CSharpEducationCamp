using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud--> Create-Read-Update-Database

            Console.WriteLine( "***** Menü Sipariş İşlem Paneli");
            #region Kategori Ekleme İşlemi
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Eklemek istediğiniz kategori adı:");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B261NU2\\MSSQLSERVER02;initial Catalog=EducationCampDb;integrated Security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.WriteLine("Kategori Başarılı bir şeklide eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //// bool productStatus;

            //Console.WriteLine("ürün Adı");
            //productName = Console.ReadLine();
            //Console.WriteLine("Ürün Fiyatı:");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B261NU2\\MSSQLSERVER02;initial Catalog=EducationCampDb;integrated Security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Eklemesi Başarılı");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B261NU2\\MSSQLSERVER02;initial Catalog=EducationCampDb;integrated Security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var ıtem in row.ItemArray)
            //    {
            //        Console.WriteLine(ıtem.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("Silinecek Ürün Id");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B261NU2\\MSSQLSERVER02;initial Catalog=EducationCampDb;integrated Security=true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı");

            #endregion

            #region Ürün Güncelle
            //Console.WriteLine("Güncellenecek Ürün Id:");
            //int productId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Güncellenecek Ürün Adı:");
            //string productName = Console.ReadLine();
            //Console.WriteLine("Güncellenecek Ürün Fiyatı:");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B261NU2\\MSSQLSERVER02;initial Catalog=EducationCampDb;integrated Security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("update TblProduct Set ProductName=@ProductName,ProductPrice=@ProductPrice where ProductId=@ProductId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı");
            #endregion

            Console.Read();
        }
    }
}
