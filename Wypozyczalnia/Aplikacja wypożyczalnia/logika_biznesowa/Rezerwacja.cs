using System;
using System.Data;
using System.Globalization;

namespace logika_biznesowa {
	public class Rezerwacja
    {
		/// <summary>
		/// numer id rezerwacji
		/// </summary>
		public int ID_rezerwacji;
		/// <summary>
		/// data, na jak¹ klient planuje wypo¿yczyæ samochód
		/// </summary>
		public DateTime Data_planowanego_wypozyczenia;
		/// <summary>
		/// data, kiedy klient planuje oddaæ samochód
		/// </summary>
		public DateTime Data_planowanego_zwrotu;
        private Samochód samochód;
        private Klient klient;
        private Panel_administratora panel_administratora;
        private Wypo¿yczenie wypo¿yczenie;
        private Lista_rezerwacji lista_rezerwacji;

        /// <summary>
        /// Konstruktor bezparametrowy
        /// </summary>
        public Rezerwacja()
        {
            ID_rezerwacji = 0;
            Data_planowanego_wypozyczenia = new DateTime(1, 1, 1);
            Data_planowanego_zwrotu = new DateTime(1, 1, 1);
        }
        /// <summary>
        /// konstruktor Rezerwacja
        /// </summary>
        public Rezerwacja(int id, DateTime dpw, DateTime dpz)
        {
            ID_rezerwacji = id;
            Data_planowanego_wypozyczenia = dpw;
            Data_planowanego_zwrotu = dpz;
        }
		/// <summary>
		/// metoda, która pokazuje rezerwacjê
		/// </summary>
		public static DataTable PokazRezerwacje(ref string _exmsg)
        {
            DataTable dt = new DataTable();

            string zapytanie = @"Select * from [dbo].[Rezerwacja]  ";
            //Pobieranie danych z bazy
            string exmsg = "";
            dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            return dt;
        }
		/// <summary>
		/// metoda, która edytuje rezerwacjê
		/// </summary>
		public void EdytujRezerwacje()
        {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, która dodaje rezerwacjê
		/// </summary>
		public string DodajRezerwacje()
        {
            string exmsg = "";
            string zapytanie = @"insert into [dbo].[Rezerwacja] ([ID_rezerwacji], [Data_planowanego_wypozyczenia], [Data_planowanego_zwrotu], [CzyUsuniete])" +
                @"values (" + ID_rezerwacji + ", " + Data_planowanego_wypozyczenia + " , " + Data_planowanego_zwrotu + " , 0)";
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }
		/// <summary>
		/// metoda, która usuwa rezerwacjê
		/// </summary>
		public static string UsunRezerwacje(int identyfikator)
        {
            string zapytanieCzyRezerwacjaIstnieje = @"SELECT count(*) FROM [dbo].[Rezerwacja] WHERE [ID_rezerwacji] = " + identyfikator;
            string exmsgTest = "";
            string zwrotZapytanieCzyRezerwacjaIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzyRezerwacjaIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest rezerwacja o danym ID zwróci³o b³¹d
                return exmsgTest;
            else // zapytanie nie zwróci³o b³êdu
            {
                int licznik;
                if (int.TryParse(zwrotZapytanieCzyRezerwacjaIstnieje, out licznik) == true) // uzyskan¹ wartoœæ da siê przekonwetowaæ na inta
                {
                    if (licznik == 1) // zapytanie zwróci³o znalezienie w bazie rezerwacji rekordu o podanym ID
                    {
                        string exmsg = "", exmsg1 = "", exmsg2 = "";
                        // usuniêcie danych z tabeli Rezerwacja
                        string zapytanie1 = @"UPDATE [dbo].[Rezerwacja] SET [CzyUsuniete] = 1 WHERE [ID_rezerwacji] = " + identyfikator;
                        FunkcjePomicnicze.WstawDaneSQL(zapytanie1, ref exmsg1);
                        // budowa informacji wyjœciowej z funkcji
                        if (!string.IsNullOrWhiteSpace(exmsg1))
                            exmsg += "\n" + exmsg1;
                        if (!string.IsNullOrWhiteSpace(exmsg2))
                            exmsg += "\n" + exmsg2;
                        return exmsg;
                    }
                    else
                        return "Nie odnaleziono rezerwacji o podanym ID";
                }
                else
                    return "Nie odnaleziono rezerwacji o podanym ID";
            }
		}
        /// <summary>
        /// metoda, która wyszukuje rezerwacjê
        /// </summary>
        public static DataTable WyszukajRezerwacje(int identyfikator, ref string _exmsg)
        {
            //throw new System.Exception("Not implemented");
            DataTable dt = new DataTable();
            string zapytanieCzyRezerwacjaIstnieje = @"SELECT count(*) from [dbo].[Rezerwacja] WHERE (([CzyUsuniete] = 0 or [CzyUsuniete] is null)" +
                @"and [Id_rezerwacji] = " + identyfikator + ")";
            string exmsgTest = "";
            string zwrotZapytanieCzyRezerwacjaIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzyRezerwacjaIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest rezerwacja o danym ID zwróci³o b³¹d
            {
                _exmsg = exmsgTest;
                return dt;
            }
            else // zapytanie nie zwróci³o b³êdu
            {
                if (zwrotZapytanieCzyRezerwacjaIstnieje != "0") // zapytanie zwróci³o znalezienie w bazie rezerwacja rekordu o podanym ID
                {
                    string exmsg = "";
                    string zapytanie = "";
                    zapytanie = @"SELECT * from[dbo].[Rezerwacja] WHERE [Id_rezerwacji] = " + identyfikator;
                    // pobranie danych z bazy
                    string exmsg1 = "";
                    dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg1);
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        _exmsg += "\n" + exmsg;
                    if (!string.IsNullOrWhiteSpace(exmsg1))
                        _exmsg += "\n" + exmsg1;
                    return dt;
                }
                else
                {
                    _exmsg = "Nie odnaleziono rezerwacji o podanym ID";
                    return dt;
                }
            }
        }
        
        public static int MaksymalnyNumerIdentyfikatoraWBazie()
        {
            string zapytanie = @"select max([ID_rezerwacji]) from [dbo].[Rezerwacja]";
            string exmsg = "";
            string numerZBazy = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(numerZBazy))
                return int.Parse(numerZBazy);
            else
                return 0;
        }
	}

}
