using System;
using System.Data;

namespace logika_biznesowa {
	public class Klient_firmy : Klient  {
        /// <summary>
		/// nazwa firmy, która wypo¿ycza samochód
		/// </summary>
		public string Nazwa_firmy;
		/// <summary>
		/// NIP firmy wypo¿yczaj¹cej samochód
		/// </summary>
		public string NIP;
        /// <summary>
        /// w³asnoœæ wskazuj¹ca, czy dany klient zosta³ oznaczony w bazie jako usuniêty
        /// </summary>
        public bool CzyUsuniete;

        /// <summary>
        /// konstruktor klient firma
        /// </summary>
        public Klient_firmy(string nazwa, string _nip)
        {
            Nazwa_firmy = nazwa;
            NIP = _nip;
        }

        /// <summary>
        /// Dodanie Klienta firmy do bazy danych
        /// </summary>
        public string DodajKlientaFirmeDoBazy(int identyfikator)
        {
            string exmsg = "";
            string zapytanie = @"INSERT INTO [dbo].[Klient_firmy] ([Id_klienta], [Nazwa_firmy], [NIP], [CzyUsuniete])" +
                @"values(" + identyfikator + ", '" + Nazwa_firmy + "', '" + NIP + "', 0)";
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            string exmsg1 = DodajDoBazyPolaczenieKlientaFirmyZKlientem(identyfikator);
            if (!string.IsNullOrWhiteSpace(exmsg1))
                exmsg += exmsg1;
            return exmsg;
        }

        public string DodajDoBazyPolaczenieKlientaFirmyZKlientem(int identyfikator)
        {
            string exmsg = "";
            string zapytanie = @"insert into[dbo].[Klient_KlientFirma] values(" + identyfikator + "," + identyfikator + ")";
            FunkcjePomicnicze.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }
    }

}
