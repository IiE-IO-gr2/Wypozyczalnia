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
        private Rezerwacja rezerwacja;
        private Klient_indywidualny klient_indywidualny;
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
        }

        /// <summary>
        /// konstruktor Wypozyczenie
        /// </summary>
        public Wypo¿yczenie(int id, DateTime dw, DateTime dpz, float czp)
        {
            ID_wypo¿yczenia = id;
            Data_wypo¿yczenia = dw;
            Data_planowanego_zwrotu = dpz;
            Cena_za_wypozyczenie = czp;
        }

        /// <summary>
        /// metoda dodaj¹ca wypo¿yczenie do bazy
        /// </summary>
        public string DodajWypozyczenie()
        {
            string exmsg = "";
            string zapytanie = @"insert into [dbo].[Wypo¿yczenie] ([ID_wypo¿yczenia], [Data_wypo¿yczenia], [Data_planowanego_zwrotu], [Cena_za_wypozyczenie], [CzyUsuniete])" +
                @"values (" + ID_wypo¿yczenia + ", " + Data_wypo¿yczenia + " , " + Data_planowanego_zwrotu + ", " + Cena_za_wypozyczenie + " , 0)";
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }

        /// <summary>
        /// metoda usuwaj¹ca wypo¿yczenie z bazy
        /// </summary>
        public static string UsunWypozyczenie(int identyfikator)
        {
            string zapytanieCzyWypozyczenieIstnieje = @"SELECT count(*) FROM [dbo].[Wypo¿yczenie] WHERE [ID_wypo¿yczenia] = " + identyfikator;
            string exmsgTest = "";
            string zwrotZapytanieCzyWypozyczenieIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzyWypozyczenieIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest wypo¿yczenie o danym ID zwróci³o b³¹d
                return exmsgTest;
            else // zapytanie nie zwróci³o b³êdu
            {
                int licznik;
                if (int.TryParse(zwrotZapytanieCzyWypozyczenieIstnieje, out licznik) == true) // uzyskan¹ wartoœæ da siê przekonwetowaæ na inta
                {
                    if (licznik == 1) // zapytanie zwróci³o znalezienie w bazie wypo¿yczeñ rekordu o podanym ID
                    {
                        string exmsg = "", exmsg1 = "", exmsg2 = "";
                        // usuniêcie danych z tabeli Wypo¿yczenie
                        string zapytanie1 = @"UPDATE [dbo].[Wypo¿yczenie] SET [CzyUsuniete] = 1 WHERE [ID_wypo¿yczenia] = " + identyfikator;
                        FunkcjePomicnicze.WstawDaneSQL(zapytanie1, ref exmsg1);
                        // budowa informacji wyjœciowej z funkcji
                        if (!string.IsNullOrWhiteSpace(exmsg1))
                            exmsg += "\n" + exmsg1;
                        if (!string.IsNullOrWhiteSpace(exmsg2))
                            exmsg += "\n" + exmsg2;
                        return exmsg;
                    }
                    else
                        return "Nie odnaleziono wypo¿yczenia o podanym ID";
                }
                else
                    return "Nie odnaleziono wypo¿yczenia o podanym ID";
            }
        }
        /// <summary>
        /// metoda edytuj¹ca wypo¿yczenie w bazie
        /// </summary>
        public void EdytujWypozyczenie()
        {
            throw new System.Exception("Not implemented");
        }
        /// <summary>
        /// metoda wyszukuj¹ca wypo¿yczenie w bazie
        /// </summary>
        public void WyszukajWypozyczenie()
        {
            throw new System.Exception("Not implemented");
        }
        /// <summary>
        /// metoda pokazuj¹ca wypo¿yczenie w bazie
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
                    zapytanie = @"select [ID_wypo¿yczenia],[Data_wypo¿yczenia],[Data_planowanego_zwrotu],[Cena_za_wypozyczenie]" +
                    @"from [dbo].[Wypo¿yczenie] where [ID_wypo¿yczenia]=" + identyfikator;
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

        public static DataTable PokazWypozyczenie(ref string _exmsg)
        {
            DataTable dt = new DataTable();

            string zapytanie = @"select [ID_wypo¿yczenia],[Data_wypo¿yczenia],[Data_planowanego_zwrotu],[Cena_za_wypozyczenie]" +
                @"from [dbo].[Wypo¿yczenie] WHERE ([CzyUsuniete] = 0 or [CzyUsuniete] is null)";
            //Pobieranie danych z bazy
            string exmsg = "";
            dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            return dt;
        }
    } 


}
