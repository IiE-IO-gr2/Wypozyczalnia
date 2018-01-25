using System;
using System.Data;
using System.Globalization;
namespace logika_biznesowa {
    public class Wypo¿yczenie
    {
        /// <summary>
        /// numer id wypo¿yczenia
        /// </summary>
        public int ID_wypo¿yczenia;
        /// <summary>
        /// data wypo¿yczenia samochodu
        /// </summary>
        public DateTime Data_wypo¿yczenia;
        /// <summary>
        /// data planowanego zwrotu samochodu
        /// </summary>
        public DateTime Data_planowanego_zwrotu;
        /// <summary>
        /// cena za wypo¿yczenie samochodu
        /// </summary>
        public double Cena_za_wypozyczenie;
        private int id_klienta;
        private int id_samochodu;
        private Rozliczenie rozliczenie;

        /// <summary>
        /// konstruktor bezparametrowy Wypozyczenie
        /// </summary>
        public Wypo¿yczenie()
        {
            ID_wypo¿yczenia = 0;
            Data_wypo¿yczenia = new DateTime(1, 1, 1);
            Data_planowanego_zwrotu = new DateTime(1, 1, 1);
            Cena_za_wypozyczenie = 0.0;
            id_klienta = 0;
            id_samochodu = 0;
        }

        /// <summary>
        /// konstruktor Wypozyczenie
        /// </summary>
        public Wypo¿yczenie(int id_w, DateTime dw, DateTime dz, double czp, int idk, int ids)
        {
            ID_wypo¿yczenia = id_w;
            Data_wypo¿yczenia = dw;
            Data_planowanego_zwrotu = dz;
            Cena_za_wypozyczenie = czp;
            id_klienta = idk;
            id_samochodu = ids;
        }

        /// <summary>
        /// metoda dodaj¹ca wypo¿yczenie do bazy
        /// </summary>
        public string DodajWypozyczenie()
        {
            string exmsg = "";
            string cena = Cena_za_wypozyczenie.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string Data_wyp = Data_wypo¿yczenia.Year.ToString() + "-" + Data_wypo¿yczenia.Month.ToString() + "-" + Data_wypo¿yczenia.Day.ToString();
            string Data_pl_zw = Data_planowanego_zwrotu.Year.ToString() + "-" + Data_planowanego_zwrotu.Month.ToString() + "-" + Data_planowanego_zwrotu.Day.ToString();
            string zapytanie = @"INSERT INTO [dbo].[Wypo¿yczenie] ([ID_wypo¿yczenia], [Data_wypo¿yczenia], [Data_planowanego_zwrotu]," +
                @"[Cena_za_wypozyczenie], [CzyUsuniete], [Id_Klienta], [Id_samochodu], [CzyRozliczone])" +
                @"VALUES(" + ID_wypo¿yczenia + ", '" + Data_wyp + "', '" + Data_pl_zw +
                "', " + cena + ", 0, " + id_klienta + ", " + id_samochodu + ", 0)";
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }

        
        /// <summary>
        /// Metoda pobieraj¹ca z bazy danych najwy¿szy dotychczas uzyty numer ID
        /// </summary>
        public static int MaksymalnyNumerIdentyfikatoraWBazie()
        {
            string zapytanie = @"select max([ID_wypo¿yczenia]) from [dbo].[Wypo¿yczenie]";
            string exmsg = "";
            string numerZBazy = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(numerZBazy))
                return int.Parse(numerZBazy);
            else
                return 0;
        }
        /// <summary>
        /// Metoda wyszukuj¹ca wypo¿yczenie w bazie
        /// </summary>
        public static DataTable WyszukajWypozyczenie(int identyfikator, ref string _exmsg)
        {
            DataTable dt = new DataTable();
            string zapytanieCzyWypozyczenieIstnieje = @"SELECT count(*) from [dbo].[Wypo¿yczenie] WHERE (([CzyUsuniete] = 0 or [CzyUsuniete] is null)" +
                @"and [ID_wypo¿yczenia] = " + identyfikator + ")";
            string exmsgTest = "";
            string zwrotZapytanieCzyWypozyczenieIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzyWypozyczenieIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest wypo¿yczenie o danym ID zwróci³o b³¹d
            {
                _exmsg = exmsgTest;
                return dt;
            }
            else // zapytanie nie zwróci³o b³êdu
            {
                string zapytanie = "";
                if (zwrotZapytanieCzyWypozyczenieIstnieje != "0") // zapytanie zwróci³o znalezienie w bazie wypozyczeñ rekordu o podanym ID
                {
                    zapytanie = @"select [ID_wypo¿yczenia], [Data_wypo¿yczenia], [Data_planowanego_zwrotu], [Cena_za_wypozyczenie]," +
                        @"[Id_Klienta], [Id_samochodu], [CzyRozliczone] from [dbo].[Wypo¿yczenie] where [ID_wypo¿yczenia]=" + identyfikator;
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
                    _exmsg = "Nie odnaleziono wypo¿yczenia o podanym ID";
                    return dt;
                }
            }
        }
        /// <summary>
        /// Metoda pokazuj¹ca wypo¿yczenie w bazie
        /// </summary>
        public static DataTable PokazWypozyczenie(ref string _exmsg)
        {
            DataTable dt = new DataTable();
            string zapytanie = @"select [ID_wypo¿yczenia], [Data_wypo¿yczenia], [Data_planowanego_zwrotu], [Cena_za_wypozyczenie]," +
                        @"[Id_Klienta], [Id_samochodu], [CzyRozliczone] from [dbo].[Wypo¿yczenie]";
            //Pobieranie danych z bazy
            string exmsg = "";
            dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            return dt;
        }
        /// <summary>
        /// Metoda pokazuj¹ca zaleg³e wypo¿yczenia w bazie
        /// </summary>
        public static DataTable PokazWypozyczenieZalegle(ref string _exmsg)
        {
            DataTable dt = new DataTable();
            string zapytanie = @"select [ID_wypo¿yczenia], [Data_wypo¿yczenia], [Data_planowanego_zwrotu], [Cena_za_wypozyczenie]," +
                        @"[Id_Klienta], [Id_samochodu] from [dbo].[Wypo¿yczenie]" +
                        @"where (Data_planowanego_zwrotu <= GETDATE() and (CzyRozliczone is null or CzyRozliczone = 0))";
            //Pobieranie danych z bazy
            string exmsg = "";
            dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            return dt;
        }
    } 


}
