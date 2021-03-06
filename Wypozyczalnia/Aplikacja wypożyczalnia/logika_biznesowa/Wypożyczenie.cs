using System;
using System.Data;
using System.Globalization;
namespace logika_biznesowa {
    public class Wypożyczenie
    {
        /// <summary>
        /// numer id wypożyczenia
        /// </summary>
        public int ID_wypożyczenia;
        /// <summary>
        /// data wypożyczenia samochodu
        /// </summary>
        public DateTime Data_wypożyczenia;
        /// <summary>
        /// data planowanego zwrotu samochodu
        /// </summary>
        public DateTime Data_planowanego_zwrotu;
        /// <summary>
        /// cena za wypożyczenie samochodu
        /// </summary>
        public double Cena_za_wypozyczenie;
        private int id_klienta;
        private int id_samochodu;

        /// <summary>
        /// konstruktor bezparametrowy Wypozyczenie
        /// </summary>
        public Wypożyczenie()
        {
            ID_wypożyczenia = 0;
            Data_wypożyczenia = new DateTime(1, 1, 1);
            Data_planowanego_zwrotu = new DateTime(1, 1, 1);
            Cena_za_wypozyczenie = 0.0;
            id_klienta = 0;
            id_samochodu = 0;
        }

        /// <summary>
        /// konstruktor Wypozyczenie
        /// </summary>
        public Wypożyczenie(int id_w, DateTime dw, DateTime dz, double czp, int idk, int ids)
        {
            ID_wypożyczenia = id_w;
            Data_wypożyczenia = dw;
            Data_planowanego_zwrotu = dz;
            Cena_za_wypozyczenie = czp;
            id_klienta = idk;
            id_samochodu = ids;
        }

        /// <summary>
        /// metoda dodająca wypożyczenie do bazy
        /// </summary>
        public string DodajWypozyczenie()
        {
            string exmsg = "";
            string cena = Cena_za_wypozyczenie.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string Data_wyp = Data_wypożyczenia.Year.ToString() + "-" + Data_wypożyczenia.Month.ToString() + "-" + Data_wypożyczenia.Day.ToString();
            string Data_pl_zw = Data_planowanego_zwrotu.Year.ToString() + "-" + Data_planowanego_zwrotu.Month.ToString() + "-" + Data_planowanego_zwrotu.Day.ToString();
            string zapytanie = @"INSERT INTO [dbo].[Wypożyczenie] ([ID_wypożyczenia], [Data_wypożyczenia], [Data_planowanego_zwrotu]," +
                @"[Cena_za_wypozyczenie], [CzyUsuniete], [Id_Klienta], [Id_samochodu], [CzyRozliczone])" +
                @"VALUES(" + ID_wypożyczenia + ", '" + Data_wyp + "', '" + Data_pl_zw +
                "', " + cena + ", 0, " + id_klienta + ", " + id_samochodu + ", 0)";
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }

        
        /// <summary>
        /// Metoda pobierająca z bazy danych najwyższy dotychczas uzyty numer ID
        /// </summary>
        public static int MaksymalnyNumerIdentyfikatoraWBazie()
        {
            string zapytanie = @"select max([ID_wypożyczenia]) from [dbo].[Wypożyczenie]";
            string exmsg = "";
            string numerZBazy = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(numerZBazy))
                return int.Parse(numerZBazy);
            else
                return 0;
        }
        /// <summary>
        /// Metoda wyszukująca wypożyczenie w bazie
        /// </summary>
        public static DataTable WyszukajWypozyczenie(int identyfikator, ref string _exmsg)
        {
            DataTable dt = new DataTable();
            string zapytanieCzyWypozyczenieIstnieje = @"SELECT count(*) from [dbo].[Wypożyczenie] WHERE (([CzyUsuniete] = 0 or [CzyUsuniete] is null)" +
                @"and [ID_wypożyczenia] = " + identyfikator + ")";
            string exmsgTest = "";
            string zwrotZapytanieCzyWypozyczenieIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzyWypozyczenieIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testujące, czy w bazie jest wypożyczenie o danym ID zwróciło błąd
            {
                _exmsg = exmsgTest;
                return dt;
            }
            else // zapytanie nie zwróciło błędu
            {
                string zapytanie = "";
                if (zwrotZapytanieCzyWypozyczenieIstnieje != "0") // zapytanie zwróciło znalezienie w bazie wypozyczeń rekordu o podanym ID
                {
                    zapytanie = @"select [ID_wypożyczenia], [Data_wypożyczenia], [Data_planowanego_zwrotu], [Cena_za_wypozyczenie]," +
                        @"[Id_Klienta], [Id_samochodu], [CzyRozliczone] from [dbo].[Wypożyczenie] where [ID_wypożyczenia]=" + identyfikator;
                    // pobranie danych z bazy
                    string exmsg = "";
                    dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        _exmsg += "\n" + exmsg;
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        _exmsg += "\n" + exmsg;
                    return dt;
                }
                else
                {
                    _exmsg = "Nie odnaleziono wypożyczenia o podanym ID";
                    return dt;
                }
            }
        }
        /// <summary>
        /// Metoda pokazująca wypożyczenie w bazie
        /// </summary>
        public static DataTable PokazWypozyczenie(ref string _exmsg)
        {
            DataTable dt = new DataTable();
            string zapytanie = @"select [ID_wypożyczenia], [Data_wypożyczenia], [Data_planowanego_zwrotu], [Cena_za_wypozyczenie]," +
                        @"[Id_Klienta], [Id_samochodu], [CzyRozliczone] from [dbo].[Wypożyczenie]";
            //Pobieranie danych z bazy
            string exmsg = "";
            dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            return dt;
        }
        /// <summary>
        /// Metoda pokazująca zaległe wypożyczenia w bazie
        /// </summary>
        public static DataTable PokazWypozyczenieZalegle(ref string _exmsg)
        {
            DataTable dt = new DataTable();
            string zapytanie = @"select [ID_wypożyczenia], [Data_wypożyczenia], [Data_planowanego_zwrotu], [Cena_za_wypozyczenie]," +
                        @"[Id_Klienta], [Id_samochodu] from [dbo].[Wypożyczenie]" +
                        @"where (Data_planowanego_zwrotu <= GETDATE() and (CzyRozliczone is null or CzyRozliczone = 0))";
            //Pobieranie danych z bazy
            string exmsg = "";
            dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            return dt;
        }
    }
}
