using System;
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
        /// metoda dodania klienta do bazy
        /// </summary>

        public void DodanieKlienta()
        {
            string query = "INSERT INTO Klienci (Id_klienta,Telefon kontaktowy, Adres, Adres_email, Promocja, Aktywnosc) VALUES('" + Id_klienta + "','" + Telefon_kontaktowy + "','" + Adres + "','" + Adres_email + "','" + Promocja + "','" + Aktywnosc + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
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
