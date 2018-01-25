using System;
using System.Data;
using System.Globalization;

namespace logika_biznesowa {
    public class Klient {
        /// <summary>
        /// numer id klienta
        /// </summary>
        public int Id_klienta;
        /// <summary>
        /// telefon kontaktowy do klienta
        /// </summary>
        public string Telefon_kontaktowy;
        /// <summary>
        /// adres zamieszkania klienta
        /// </summary>
        public string Adres;
        /// <summary>
        /// adres e-mail klienta
        /// </summary>
        public string Adres_email;
        /// <summary>
        /// promocja uzale¿niona od iloœci wypo¿yczeñ klienta
        /// </summary>
        public double Promocja;
        /// <summary>
        /// ile razy klient wypo¿yczy³ samochód, nastêpnie od tego liczona jest promocja
        /// </summary>
        public int Aktywnosc;
        /// <summary>
        /// w³asnoœæ wskazuj¹ca, czy dany klient zosta³ oznaczony w bazie jako usuniêty
        /// </summary>
        public bool CzyUsuniete;

        /// <summary>
        /// konstruktor bezparametrowy Klient
        /// </summary>
        public Klient()
        {
            Id_klienta = 0;
            Telefon_kontaktowy = "000000000";
            Adres = "";
            Adres_email = "";
            Promocja = 0.0;
            Aktywnosc = 0;
        }

        /// <summary>
        /// konstruktor Klient
        /// </summary>
        public Klient(int id, string tl, string ad, string em, double pr, int ak)
        {
            Id_klienta = id;
            Telefon_kontaktowy = tl;
            Adres = ad;
            Adres_email = em;
            Promocja = pr;
            Aktywnosc = ak;
        }

        /// <summary>
        /// metoda dodania klienta do bazy
        /// </summary>
        public string DodanieKlienta()
        {
            string exmsg = "";
            string promo = Promocja.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string zapytanie = @"insert into [dbo].[Klient] ([Id_klienta], [Telefon_kontaktowy], [Adres], [Adres_email], [Promocja], [Aktywnosc], [CzyUsuniete])" +
                @"values (" + Id_klienta + ", '" + Telefon_kontaktowy + "' , '" + Adres + "', '" + Adres_email + "', " + promo + ", " + Aktywnosc + ",0)";
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }

        /// <summary>
        /// metoda usuniêcia klienta z bazy
        /// </summary>
        /// <param name="identyfikator">numer identyfikacyjny klienta, który ma zostaæ usuniêty z bazy</param>
        /// <returns></returns>
        public static string UsunKlienta(int identyfikator)
        {
            string zapytanieCzyKlientIstnieje = @"SELECT count(*) FROM [dbo].[Klient] WHERE [Id_klienta] = " + identyfikator;
            string exmsgTest = "";
            string zwrotZapytanieCzyKlientIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzyKlientIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest klient o danym ID zwróci³o b³¹d
                return exmsgTest;
            else // zapytanie nie zwróci³o b³êdu
            {
                int licznik;
                if (int.TryParse(zwrotZapytanieCzyKlientIstnieje, out licznik) == true) // uzyskan¹ wartoœæ da siê przekonwetowaæ na inta
                {
                    if (licznik == 1) // zapytanie zwróci³o znalezienie w bazie klientów rekordu o podanym ID
                    {
                        string exmsg = "", exmsg1 = "", exmsg2 = "";
                        // usuniêcie danych z tabeli Klienci
                        string zapytanie1 = @"UPDATE [dbo].[Klient] SET [CzyUsuniete] = 1 WHERE [Id_klienta] = " + identyfikator;
                        FunkcjePomicnicze.WstawDaneSQL(zapytanie1, ref exmsg1);
                        // sprawdzenie, czy klient by³ klientem indywidualnym, czy firm¹
                        string zapytanieTestoweCzyKlientFirma = @"SELECT count(*) FROM [dbo].[Klient_KlientFirma] WHERE [Id_klienta_K] = " + identyfikator;
                        string liczbaRekordow = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieTestoweCzyKlientFirma, ref exmsg);
                        // budowa zapytania aktualizuj¹cego klienta_indywidualnego lub klienta_firmê
                        string zapytanie2 = "";
                        if (liczbaRekordow == "0") // czyli nie jest to klient-firma
                            zapytanie2 = @"UPDATE [dbo].[Klient_indywidualny] ";
                        else
                            zapytanie2 = @"UPDATE [dbo].[Klient_firmy] ";
                        zapytanie2 += @"SET[CzyUsuniete] = 1 WHERE[Id_klienta] = " + identyfikator;
                        // update klienta-indywidualnego lub klienta-firmy
                        FunkcjePomicnicze.WstawDaneSQL(zapytanie2, ref exmsg2);
                        // budowa informacji wyjœciowej z funkcji
                        if (!string.IsNullOrWhiteSpace(exmsg1))
                            exmsg += "\n" + exmsg1;
                        if (!string.IsNullOrWhiteSpace(exmsg2))
                            exmsg += "\n" + exmsg2;
                        return exmsg;
                    }
                    else
                        return "Nie odnaleziono klienta o podanym ID";
                }
                else
                    return "Nie odnaleziono klienta o podanym ID";
            }

            
		}
		/// <summary>
		/// metoda wyszukania klienta w bazie
		/// </summary>
        public static DataTable WyszukajKlienta(int identyfikator, ref string _exmsg)
        {
            DataTable dt = new DataTable();
            string zapytanieCzyKlientIstnieje = @"SELECT count(*) from [dbo].[Klient] WHERE (([CzyUsuniete] = 0 or [CzyUsuniete] is null)" +
                @"and [Id_klienta] = " + identyfikator + ")";
            string exmsgTest = "";
            string zwrotZapytanieCzyKlientIstnieje = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieCzyKlientIstnieje, ref exmsgTest);
            if (!string.IsNullOrWhiteSpace(exmsgTest)) // zapytanie testuj¹ce, czy w bazie jest klient o danym ID zwróci³o b³¹d
            {
                _exmsg = exmsgTest;
                return dt;
            }
            else // zapytanie nie zwróci³o b³êdu
            {
                if (zwrotZapytanieCzyKlientIstnieje != "0") // zapytanie zwróci³o znalezienie w bazie klientów rekordu o podanym ID
                {
                    // sprawdzenie, czy klient by³ klientem indywidualnym, czy firm¹
                    string exmsg = "";
                    string zapytanieTestoweCzyKlientFirma = @"SELECT count(*) FROM [dbo].[Klient_KlientFirma] WHERE [Id_klienta_K] = " + identyfikator;
                    string liczbaRekordow = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieTestoweCzyKlientFirma, ref exmsg);
                    // budowa zapytania wyszukuj¹cego klienta_indywidualnego lub klienta_firmê
                    string zapytanie = "";
                    if (liczbaRekordow != "0") // czyli jest to klient-firma
                    {
                        zapytanie = @"SELECT k.Id_klienta, kf.Nazwa_firmy, kf.NIP, k.Telefon_kontaktowy, k.Adres_email, k.Adres, " +
                            @"k.Promocja, k.Aktywnosc from[dbo].[Klient] as k inner join [dbo].[Klient_firmy] as kf " +
                            @"on k.Id_klienta = kf.Id_klienta WHERE k.[Id_klienta] = " + identyfikator;
                    }
                    else
                    {
                        zapytanie = @"SELECT k.Id_klienta, ki.Imiê, ki.Nazwisko, ki.Numer_prawa_jazdy, ki.PESEL, ki.P³ec, " +
                            @"k.Telefon_kontaktowy, k.Adres_email, k.Adres, k.Promocja, k.Aktywnosc from[dbo].[Klient] as k inner join " +
                            @"[dbo].[Klient_indywidualny] as ki on k.Id_klienta = ki.Id_klienta WHERE k.[Id_klienta] = " + identyfikator;
                    }
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
                    _exmsg = "Nie odnaleziono klienta o podanym ID";
                    return dt;
                }
            }
        }
		/// <summary>
		/// metoda aktualizuj¹ca dane klienta w bazie
		/// </summary>
		public string EdytujKlienta()
        {
            string exmsg = "";
            string promo = Promocja.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string zapytanie = @"update [dbo].[Klient] set [Telefon_kontaktowy] = '" + Telefon_kontaktowy + @"', [Adres] = '" + Adres + @"', " +
                @"[Adres_email] = '" + Adres_email + "', [Promocja] = " + promo + ", [Aktywnosc] = " + Aktywnosc + "where [Id_klienta] = " + Id_klienta;
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }

		private PanelAdministratora panel_administratora;

		private Rezerwacja rezerwacja;


        /// <summary>
        /// Metoda pobieraj¹ca z bazy danych najwy¿szy dotychczas uzyty numer ID
        /// </summary>
        /// <returns></returns>
        public static int MaksymalnyNumerIdentyfikatoraWBazie()
        {
            string zapytanie = @"select max([Id_klienta]) from [dbo].[Klient]";
            string exmsg = "";
            string numerZBazy = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(numerZBazy))
                return int.Parse(numerZBazy);
            else
                return 0;
        }

    }

}
