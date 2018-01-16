using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;

public static class FunkcjePomicnicze
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
    /// Pobieranie z bazy wartości z pierwszej kolumny ostatniego wiersza
    /// Co w przypadku zapytań typu "select count()" zwraca jedną wartość
    /// </summary>
    /// <param name="zapytanie">Zapytanie SQL nastawione na zwrócenie jednej wartości</param>
    /// <param name="exmsg">exit message - informacja zwrotna wywołania zapytania sql</param>
    /// <returns></returns>
    public static string PobierzDaneSQLPojedyncze(string zapytanie, ref string exmsg)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            DataTable dt = new DataTable();
            string wartosc = "";
            try
            {
                SqlDataReader dr;
                SqlCommand sqlc;
                sqlc = new SqlCommand(zapytanie);
                sqlc.Connection = conn;
                conn.Open();
                dr = sqlc.ExecuteReader();
                dt.Load(dr);
                foreach (DataRow item in dt.Rows)
                    wartosc = item[0].ToString();
                conn.Close();
                return wartosc;
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
            return wartosc;
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

    public static void WyslijMaila(string tytulMaila, string trescMaila, List<string> listaAdresatow, ref string exmsg)
    {
        string SmptServer = "smtp.gmail.com";
        int Port = 587;
        string Email = "iie.io.gr2@gmail.com";
        string Login = "iie.io.gr2@gmail.com";
        string Haslo = "gr2IOiie";
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient smpt = new SmtpClient(SmptServer);
            mail.From = new MailAddress(Email);
            foreach (string adresEmail in listaAdresatow)
            {
                mail.To.Add(adresEmail);
            }
            mail.Subject = tytulMaila;
            mail.Body = trescMaila;
            smpt.Port = Port;
            smpt.Credentials = new System.Net.NetworkCredential(Login, Haslo);
            smpt.EnableSsl = true;
            smpt.Send(mail);
        }
        catch (Exception ex)
        {
            exmsg = ex.Message;
        }
    }              

}