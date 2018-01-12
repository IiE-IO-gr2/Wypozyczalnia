using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public static class FunkcjeSQL
{
    public static string connString = @"Password=iieIOgr2;Persist Security Info=True;User ID=IOadmin;Initial Catalog=wypozyczalnia;"+
        @"Data Source=iie-io-gr2.database.windows.net";

    /// <summary>
    /// Pobieranie danych z bazy
    /// </summary>
    /// <param name="zapytanie">zapytanie SQL</param>
    /// <param name="exmsg">exit message - informacja zwrotna wywołania zapytania sql</param>
    /// <returns></returns>
    public static DataTable PobierzDaneSQL(string zapytanie, ref string exmsg)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader dr;
                SqlCommand sqlc;
                sqlc = new SqlCommand(zapytanie);
                sqlc.Connection = conn;
                conn.Open();
                dr = sqlc.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                exmsg += "\nSQL: " + ex.Message + " " + ex.Number + " " + ex.ErrorCode + " " + ex.LineNumber;
                conn.Close();
            }
            catch (Exception ex)
            {
                exmsg += "\nSys: " + ex.Message;
                conn.Close();
            }
            return dt;
        }
    }

    /// <summary>
    /// Wstawianie danych do bazy
    /// </summary>
    /// <param name="zapytanie">zapytanie SQL (insert values into...)</param>
    /// <param name="exmsg">exit message - informacja zwrotna wywołania zapytania sql</param>
    public static void WstawDaneSQL(string zapytanie, ref string exmsg)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            try
            {
                SqlCommand sqlc = new SqlCommand(zapytanie);
                sqlc.CommandType = CommandType.Text;
                sqlc.Connection = conn;
                conn.Open();
                sqlc.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                exmsg += "\nSQL: " + ex.Message + " " + ex.Number + " " + ex.ErrorCode + " " + ex.LineNumber;
                conn.Close();
            }
            catch (Exception ex)
            {
                exmsg += "\nSys: " + ex.Message;
                conn.Close();
            }
        }
    }


}