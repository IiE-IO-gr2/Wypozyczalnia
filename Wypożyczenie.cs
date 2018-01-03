using System;
namespace logika_biznesowa {
	public class Wypo¿yczenie {
		/// <summary>
		/// numer id wypo¿yczenia
		/// </summary>
		public int ID_wypo¿yczenia;
		/// <summary>
		/// data wypo¿yczenia samochodu
		/// </summary>
		public string Data_wypo¿yczenia;
		/// <summary>
		/// data planowanego zwrotu samochodu
		/// </summary>
		public string Data_planowanego_zwrotu;
		/// <summary>
		/// cena za wypo¿yczenie samochodu
		/// </summary>
		public float Cena_za_wypozyczenie;

		/// <summary>
		/// metoda dodaj¹ca wypo¿yczenie do bazy
		/// </summary>
		public void DodajWypozyczenie() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda usuwaj¹ca wypo¿yczenie z bazy
		/// </summary>
		public void UsunWypozyczenie() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda edytuj¹ca wypo¿yczenie w bazie
		/// </summary>
		public void EdytujWypozyczenie() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda wyszukuj¹ca wypo¿yczenie w bazie
		/// </summary>
		public void WyszukajWypozyczenie() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda pokazuj¹ca wypo¿yczenie w bazie
		/// </summary>
		public void PokazWypozyczenie() {
			throw new System.Exception("Not implemented");
		}

		private Rezerwacja rezerwacja;

		private Klient_indywidualny klient_indywidualny;
		private Rozliczenie rozliczenie;

	}

}
