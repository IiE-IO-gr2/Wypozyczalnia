using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public static class Funkcje
{
    public static string connString = @"Password=IOadmin;Persist Security Info=True;User ID = IOadmin; Initial Catalog = wypozyczalnia;" +
        @"Data Source = 10.64.232.0,49172";
    
    // @"Provider = SQLOLEDB.1; Password=IOadmin;Persist Security Info=True;User ID = IOadmin; Initial Catalog = wypozyczalnia; Data Source = 10.78.246.150,49172";
    // @"server=tcp:KRYCHCIAPC,49172;database=wypozyczalnia;UID=IOadmin;password=IOadmin";

    //"Data Source = 10.174.37.101; Network Library = DBMSSOCN;" +
    //"Initial Catalog = wypozyczalnia; User ID = IOadmin; Password=IOadmin;";
    
    // @"Data Source=KRYCHCIAPC\\SQLEXPRESS,2301;Network Library=DBMSSOCN;" +
    // @"Initial Catalog=wypozyczalnia;User ID=IOadmin;Password=IOadmin;";
    
    // "server=KRYCHCIAPC\\SQLEXPRESS;database=wypozyczalnia;UID=IOadmin;password=IOadmin";


    //Pobieranie danych z bazy
    //poprzez zapytanie SQL np. "select * from [dbo].[samochod]"
    //ref exmsg - string z ew. tekstami błędów
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

    // Może się do czegoś przyda. Wywołanie wewnętrzej procedury bazy z parametrem (tutaj plik xml)
    public static string WywolajProcedureSQL(string connString, string sciezka, string nazwa_procedury)
    {
        string a = "";
        if (string.IsNullOrEmpty(sciezka))
        {
            a += "Błędna ściezka";
        }
        using (SqlConnection conn = new SqlConnection(connString))
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(nazwa_procedury, conn);
                cmd.CommandTimeout = 600;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@XML_FILE", sciezka);
                cmd.ExecuteNonQuery();
                conn.Close();
                return a;
            }
            catch (SqlException ex)
            {
                a += "\nSQL: " + ex.Message + " " + ex.Number + " " + ex.ErrorCode + " " + ex.LineNumber;
                conn.Close();
                return a;
            }
            catch (Exception ex)
            {
                a += "Sys: " + ex.Message;
                conn.Close();
                return a;
            }
            //finally { conn.Close(); }
        }
    }
}