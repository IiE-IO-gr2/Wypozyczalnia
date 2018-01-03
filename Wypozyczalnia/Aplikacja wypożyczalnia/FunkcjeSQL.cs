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

    //Wstawianie danych do bazy
    //poprzez zapytanie SQL (insert values into...)
    //exmsg - powinien być try-catch jak w funkcji powyżej
    public static void WstawDaneSQL(string zapytanie, ref string exmsg)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlCommand sqlc = new SqlCommand(zapytanie);
            sqlc.CommandType = CommandType.Text;
            sqlc.Connection = conn;
            conn.Open();
            sqlc.ExecuteNonQuery();
            conn.Close();
        }
    }
}