using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace ExcelUpdateSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SQLServer;Initial Catalog=MyDatabase;Integrated Security=SSPI;");
            conn.Open();
            OleDbConnection Xcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\MyExcelFile.xlsx;Extended Properties=Excel 12.0");
            OleDbDataAdapter Xda = new OleDbDataAdapter("select * from [Sheet1$]", Xcon);
            DataTable Xdt = new DataTable();
            Xda.Fill(Xdt);
            try
            {
                foreach (DataRow row in Xdt.Rows) 
                {
                    SqlCommand cmd = new SqlCommand(@"update MyTable set MyField = '" + row[1].ToString() + "' where MySelectedField = '" + row[0].ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }
            Console.WriteLine(Xdt.Rows.Count);
            Console.Read();
        }
    }
}