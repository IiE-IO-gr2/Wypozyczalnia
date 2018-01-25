using System;
using System.Data;
using System.Globalization;
namespace logika_biznesowa {
    public class Samochód {
		/// <summary>
		/// numer id samochodu
		/// </summary>
		public int Id_samochodu;
		/// <summary>
		/// marka samochodu
		/// </summary>
		public string Marka;
		/// <summary>
		/// model samochodu
		/// </summary>
		public string Model;
		/// <summary>
		/// pojemnoœæ silnika samochodu
		/// </summary>
		public double Pojemnosc;
		/// <summary>
		/// rodzaj paliwa w samochodzie
		/// </summary>
		public string Rodzaj_paliwa;
		/// <summary>
		/// typ nadwozia samochodu
		/// </summary>
		public string Typ_nadwozia;
		/// <summary>
		/// iloœæ koni mechanicznych w samochodzie
		/// </summary>
		public int Ilosc_koni;
		/// <summary>
		/// skrzynia biegów w samochodzie (manualna/automatyczna)
		/// </summary>
		public string Skrzynia_biegow;
		/// <summary>
		/// iloœæ biegów w samochodzie
		/// </summary>
		public int Ilosc_biegów;
		/// <summary>
		/// zu¿ycie paliwa samochodu na 100km
		/// </summary>
		public double Zu¿ycie_paliwa;
		/// <summary>
		/// iloœæ miejsc w samochodzie
		/// </summary>
		public int Ilosc_miejsc;
		/// <summary>
		/// iloœæ drzwi w samochodzie
		/// </summary>
		public int Ilosc_drzwi;
		/// <summary>
		/// rok produkcji samochodu
		/// </summary>
		public int Rocznik;
		/// <summary>
		/// kolor samochodu
		/// </summary>
		public string Kolor;
		/// <summary>
		/// cena za dobê wypo¿yczenia samochodu
		/// </summary>
		public double Cena_za_dobê;
		/// <summary>
		/// czy samochód jest dostêpny w wypo¿yczalni czy jest w naprawie
		/// </summary>
		public bool Dostepnosc;
		/// <summary>
		/// inne uwagi
		/// </summary>
		public string Inne;
		/// <summary>
		/// kaucja zwrotna za samochód p³atna przy wypo¿yczeniu pod warunkiem, ¿e nie dokonano ¿adnych uszkodzeñ
		/// </summary>
		public int Kaucja;

		/// <summary>
		/// metoda dodaj¹ca samochód do bazy
		/// </summary>
        public Samochód()
        {
            Id_samochodu = 0;
            Marka = "";
            Model = "";
            Pojemnosc = 0.0;
            Rodzaj_paliwa = "";
            Typ_nadwozia = "";
            Ilosc_koni = 0;
            Skrzynia_biegow = "";
            Ilosc_biegów = 0;
            Zu¿ycie_paliwa = 0.0;
            Ilosc_miejsc = 0;
            Ilosc_drzwi = 0;
            Rocznik = 0;
            Kolor = "";
            Cena_za_dobê = 0.0;
            Dostepnosc = false;
            Inne = "";
            Kaucja = 0;
        }

        /// <summary>
        /// konstruktor Samochód
        /// </summary>
        public Samochód(int id, string mar, string mod, double poj, string rp, string tn, int ik, string sk, int ib, double zuz, int im, int ilodr, int roc, string kol, double czd, bool dostep, string inne, int ka)
        {
            Id_samochodu = id;
            Marka = mar;
            Model = mod;
            Pojemnosc = poj;
            Rodzaj_paliwa = rp;
            Typ_nadwozia = tn;
            Ilosc_koni = ik;
            Skrzynia_biegow = sk;
            Ilosc_biegów = ib;
            Zu¿ycie_paliwa = zuz;
            Ilosc_miejsc = im;
            Ilosc_drzwi = ilodr;
            Rocznik = roc;
            Kolor = kol;
            Cena_za_dobê = czd;
            Dostepnosc = dostep;
            Inne = inne;
            Kaucja = ka;
        }

        /// <summary>
        /// metoda dodania samochodu do bazy
        /// </summary>
        /// <returns>
        /// Zwraca wartoœci samochodu
        /// </returns>
        public string DodajSamochod()
        {
            string exmsg = "";
            int dostbool = 0;
            if (Dostepnosc == true)
                dostbool = 1;
            string poj = Pojemnosc.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string zuz = Zu¿ycie_paliwa.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string czd = Cena_za_dobê.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string zapytanie = @"insert into [dbo].[Samochód] ([Id_samochodu], [Marka], [Model], [Pojemnosc], " +
                @"[Rodzaj_paliwa], [Typ_nadwozia], [Ilosc_koni], [Skrzynia_biegow], [Ilosc_biegów], [Zu¿ycie_paliwa], " + 
                @"[Ilosc_miejsc], [Ilosc_drzwi], [Rocznik], [Kolor], [Cena_za_dobê], [Dostepnosc], [Inne], [Kaucja], [CzyUsuniete] )" +
                @"values (" + Id_samochodu + ", '" + Marka + "' , '" + Model + "', " + poj + ", '" + Rodzaj_paliwa + "', '" + 
                Typ_nadwozia + "', " + Ilosc_koni + ", '" + Skrzynia_biegow + "', " + Ilosc_biegów + ", " + zuz + ", " + 
                Ilosc_miejsc + ", " + Ilosc_drzwi + ", " + Rocznik + ", '" + Kolor + "', " + czd + ", " + dostbool + ", '" + 
                Inne + "', " + Kaucja + ",0)";
            /// <summary>
            //wstawia wartoœci atrybutów u¿ytych w zapytaniu
            /// </summary>
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }

        /// <summary>
        /// metoda edytuj¹ca samochód w bazie
        /// </summary>
        /// <returns>
        /// Zwraca wartoœci samochodu do edycji, nastêpnie edytuje samochód
        /// </returns>
        public string EdytujSamochod()
        {
            string exmsg = "";
            string poj = Pojemnosc.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string zuz = Zu¿ycie_paliwa.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string czd = Cena_za_dobê.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            int dostbool = 0;
            if (Dostepnosc == true)
                dostbool = 1;
            /// <summary>
            ///zapytanie, które umo¿liwia edycjê samochodu w opcji edycji
            /// </summary>
            string zapytanie = @"UPDATE [dbo].[Samochód] SET [Marka]='" + Marka + "', [Model]='" + Model + "', [Pojemnosc]=" +
                poj + ",[Rodzaj_paliwa]='" + Rodzaj_paliwa + "', [Typ_nadwozia]='" + Typ_nadwozia + "', [Ilosc_koni]=" + 
                Ilosc_koni + ",[Skrzynia_biegow]='" + Skrzynia_biegow + "', [Ilosc_biegów]=" + Ilosc_biegów + 
                ", [Zu¿ycie_paliwa]=" + zuz + ",[Ilosc_miejsc]=" + Ilosc_miejsc + ", [Ilosc_drzwi]= " + Ilosc_drzwi + 
                ", [Rocznik]=" + Rocznik + ", [Kolor]='" + Kolor + "', [Cena_za_dobê]=" + czd + ", [Dostepnosc]=" + dostbool + 
                ", [Inne]='" + Inne + "', [Kaucja]=" + Kaucja + " WHERE [Id_samochodu] = " + Id_samochodu;
            /// <summary>
            ///wstawia wartoœci atrybutów u¿ytych w zapytaniu
            /// </summary>
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }
        /// <summary>
        /// metoda usuwaj¹ca samochód z bazy
        /// </summary>
        /// <returns>
        /// Zwraca wartoœci samochodu do usuniêcia, nastêpnie usuwa samochód
        /// </returns>
        public static string UsunSamochod(int identyfikator)
        {
            /// <summary>
            ///sprawdza czy samochód jest w bazie
            /// </summary>
            string zapytanieCzySamochodIstnieje = @"SELECT count(*) FROM [dbo].[Samochód] WHERE [Id_samochodu] = " + identyfikator;
            string exmsgTest = "";
            string zwrotZapytanieCzySamochodIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzySamochodIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest samochód o danym ID zwróci³o b³¹d
                return exmsgTest;
            else // zapytanie nie zwróci³o b³êdu
            {
                int licznik;
                if (int.TryParse(zwrotZapytanieCzySamochodIstnieje, out licznik) == true) // uzyskan¹ wartoœæ da siê przekonwetowaæ na inta
                {
                    if (licznik == 1) // zapytanie zwróci³o znalezienie w bazie samochodów rekordu o podanym ID
                    {
                        string exmsg = "", exmsg1 = "", exmsg2 = "";
                        /// <summary>
                        /// usuniêcie danych z tabeli Samochody
                        /// </summary>
                        string zapytanie1 = @"UPDATE [dbo].[Samochód] SET [CzyUsuniete] = 1 WHERE [Id_samochodu] = " + identyfikator;
                        /// <summary>
                        ///wstawia wartoœci atrybutów u¿ytych w zapytaniu
                        /// </summary>
                        FunkcjePomicnicze.WstawDaneSQL(zapytanie1, ref exmsg1);
                        /// <summary>
                        /// budowa informacji wyjœciowej z funkcji
                        /// </summary>
                        if (!string.IsNullOrWhiteSpace(exmsg1))
                            exmsg += "\n" + exmsg1;
                        if (!string.IsNullOrWhiteSpace(exmsg2))
                            exmsg += "\n" + exmsg2;
                        return exmsg;
                    }
                    else
                        return "Nie odnaleziono samochodu o podanym ID";
                }
                else
                    return "Nie odnaleziono samochodu o podanym ID";
            }
		}
        /// <summary>
        /// metoda wyszukuj¹ca samochód w bazie
        /// </summary>      
        /// <returns>
        /// Zwraca wartoœci samochodu wyszukiwanego
        /// </returns>
        public static DataTable WyszukajSamochod(int identyfikator, ref string _exmsg)
        {
            DataTable dt = new DataTable();
            /// <summary>
            ///sprawdza czy samochód jest w bazie
            /// </summary>
            string zapytanieCzySamochodIstnieje = @"SELECT count(*) from [dbo].[Samochód] WHERE (([CzyUsuniete] = 0 or [CzyUsuniete] is null)" +
                @"and [Id_samochodu] = " + identyfikator + ")";
            string exmsgTest = "";
            string zwrotZapytanieCzySamochodIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzySamochodIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest samochód o danym ID zwróci³o b³¹d
            {
                _exmsg = exmsgTest;
                return dt;
            }
            else // zapytanie nie zwróci³o b³êdu
            {
                if (zwrotZapytanieCzySamochodIstnieje != "0") // zapytanie zwróci³o znalezienie w bazie samochód rekordu o podanym ID
                {
                    string exmsg = "";
                    string zapytanie = "";
                    /// <summary>
                    ///pokazuje wszystkie wartoœci atrybutów szukanego samochodu
                    /// </summary>
                    zapytanie = @"SELECT * from[dbo].[Samochód] WHERE [Id_samochodu] = " + identyfikator;
                    /// <summary>
                    /// pobranie danych z bazy
                    /// </summary>
                    string exmsg1 = "";
                    /// <summary>
                    ///wstawia wartoœci atrybutów u¿ytych w zapytaniu do tabeli
                    /// </summary>
                    dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg1);
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        _exmsg += "\n" + exmsg;
                    if (!string.IsNullOrWhiteSpace(exmsg1))
                        _exmsg += "\n" + exmsg1;
                    return dt;
                }
                else
                {
                    _exmsg = "Nie odnaleziono samochodu o podanym ID";
                    return dt;
                }
            }
        }
        /// <summary>
        ///metoda pokazuj¹ca listê samochodów
        /// </summary>
        /// <returns>
        /// Zwraca wartoœci wszytkich samochodów w liœcie
        /// </returns>
        public static DataTable PokazSamochody(ref string _exmsg)
        {
            DataTable dt = new DataTable();

            string zapytanie = @"Select * from [dbo].[Samochód]  ";
            //Pobieranie danych z bazy
            string exmsg = "";
            dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            return dt;
        }
        /// <summary>
        /// metoda sprawdzaj¹ca czy samochód jest dostêpny w bazie
        /// </summary>
        /*public bool CzyDostepny() {
			throw new System.Exception("Not implemented");
		}*/

        private PanelAdministratora panel_administratora;

		private Rezerwacja rezerwacja;

        /// <summary>
        /// Metoda pobieraj¹ca z bazy danych najwy¿szy dotychczas uzyty numer ID
        /// </summary>
        /// <returns>
        /// zwraca kolejny numer ID
        /// </returns>
        public static int MaksymalnyNumerIdentyfikatoraWBazie()
        {
            string zapytanie = @"select max([Id_samochodu]) from [dbo].[Samochód]";
            string exmsg = "";
            string numerZBazy = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(numerZBazy))
                return int.Parse(numerZBazy);
            else
                return 0;
        }
	}

}
