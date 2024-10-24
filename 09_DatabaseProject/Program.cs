using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DataBaseProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünlerler");
            Console.WriteLine("3-Siparişlerler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0AI6GGL\\SQLEXPRESS; Initial Catalog=CampDB; Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Read();
        }
    }
}