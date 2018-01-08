using System;
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
            Id_klienta =id;
            Telefon_kontaktowy = tl;
            Adres = ad;
            Adres_email = em;
            Promocja = pr;
            Aktywnosc = ak;
        }


        /// <summary>
        /// metoda dodania klienta do bazy danych
        /// </summary>
        public string DodajKlientaDoBazy()
        {
            string exmsg = "";
            string promo = Promocja.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
            string zapytanie = @"insert into [dbo].[Klient] ([Id_klienta], [Telefon_kontaktowy], [Adres], [Adres_email], [Promocja], [Aktywnosc])" +
                @"values (" + Id_klienta + ", '" + Telefon_kontaktowy + "' , '" + Adres + "', '" + Adres_email + "', " + promo + ", " + Aktywnosc + ")";
            FunkcjeSQL.WstawDaneSQL(zapytanie, ref exmsg);
            return exmsg;
        }

        /// <summary>
        /// metoda dodania klienta do bazy
        /// </summary>
        public void DodanieKlienta()
        {
            string query = "INSERT INTO Klienci (Id_klienta,Telefon kontaktowy, Adres, Adres_email, Promocja, Aktywnosc) VALUES('" + Id_klienta + "','" + Telefon_kontaktowy + "','" + Adres + "','" + Adres_email + "','" + Promocja + "','" + Aktywnosc + "')";

            
           
        }
        /// <summary>
        /// metoda usuniêcia klienta z bazy
        /// </summary>
        public void UsunKlienta() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda wyszukania klienta w bazie
		/// </summary>
		public void WyszukajKlienta() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda edytowania klienta w bazie
		/// </summary>
		public void EdytujKlienta() {
			throw new System.Exception("Not implemented");
		}

		private Panel_administratora panel_administratora;

		private Rezerwacja rezerwacja;

	}

}
