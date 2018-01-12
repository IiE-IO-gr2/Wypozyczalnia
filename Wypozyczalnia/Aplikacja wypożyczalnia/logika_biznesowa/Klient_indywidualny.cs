using System;
using Aplikacja_wypo¿yczalnia;

namespace logika_biznesowa {
	public class Klient_indywidualny : Klient  {
		/// <summary>
		/// imiê klienta indywidualnego
		/// </summary>
		public string Imiê;
		/// <summary>
		/// nazwisko klienta indywidualnego
		/// </summary>
		public string Nazwisko;
		/// <summary>
		/// numer prawa jazdy klienta indywidualnego
		/// </summary>
		public string Numer_prawa_jazdy;
		/// <summary>
		/// numer PESEL klienta indywidualnego
		/// </summary>
		public string PESEL;
		/// <summary>
		/// p³eæ klienta indywidualnego
		/// </summary>
		public bool P³ec;
        /// <summary>
        /// w³asnoœæ wskazuj¹ca, czy dany klient zosta³ oznaczony w bazie jako usuniêty
        /// </summary>
        public bool CzyUsuniete;

        private Wypo¿yczenie wypo¿yczenie;
        
        /// <summary>
        /// konstruktor klient indtywidualny
        /// </summary>
        public Klient_indywidualny(string im, string nz, string nr, string ps, bool pl)
        {
            Imiê = im;
            Nazwisko = nz;
            Numer_prawa_jazdy = nr;
            PESEL = ps;
            P³ec = pl;
            CzyUsuniete = false;
        }

        /// <summary>
        /// Dodanie Klienta indywidualnego do bazy danych
        /// </summary>
        public string DodajKlientaIndywidualnegoDoBazy(int identyfikator)
        {
            string exmsg = "";
            int plecBool = 0;
            if (P³ec == true)
                plecBool = 1;
            string zapytanie = @"insert into[dbo].[Klient_indywidualny]([Id_klienta], [Imiê], [Nazwisko], [Numer_prawa_jazdy], [PESEL], [P³ec], [CzyUsuniete])" +
                @"values(" + identyfikator + ", '" + Imiê + "', '" + Nazwisko + "', '" + Numer_prawa_jazdy + "', " + PESEL + "," + plecBool + " , 0)";
            FunkcjeSQL.WstawDaneSQL(zapytanie, ref exmsg);
            string exmsg1 = DodajDoBazyPolaczenieKlientaIndywidualnegoZKlientem(identyfikator);
            if (!string.IsNullOrWhiteSpace(exmsg1))
                exmsg += exmsg1;
            return exmsg;
        }

        public string DodajDoBazyPolaczenieKlientaIndywidualnegoZKlientem(int identyfikator)
        {
            string exmsg = "";
            string zapytanie = @"insert into[dbo].[Klient_KlientIndyw] values(" + identyfikator + "," + identyfikator + ")";
            FunkcjeSQL.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }
	}

}
