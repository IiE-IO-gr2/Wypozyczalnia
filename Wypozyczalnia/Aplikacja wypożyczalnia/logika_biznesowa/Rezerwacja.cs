using System;
namespace logika_biznesowa {
	public class Rezerwacja {
		/// <summary>
		/// numer id rezerwacji
		/// </summary>
		public int ID_rezerwacji;
		/// <summary>
		/// data, na jak¹ klient planuje wypo¿yczyæ samochód
		/// </summary>
		public string Data_planowanego_wypozyczenia;
		/// <summary>
		/// data, kiedy klient planuje oddaæ samochód
		/// </summary>
		public string Data_planowanego_zwrotu;

		/// <summary>
		/// metoda, która pokazuje rezerwacjê
		/// </summary>
		public void PokazRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, która edytuje rezerwacjê
		/// </summary>
		public void EdytujRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, która dodaje rezerwacjê
		/// </summary>
		public void DodajRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, która usuwa rezerwacjê
		/// </summary>
		public void UsunRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, która wyszukuje rezerwacjê
		/// </summary>
		public void WyszukajRezerwacje() {
			throw new System.Exception("Not implemented");
		}

		private Samochód samochód;
		private Klient klient;
		private Panel_administratora panel administratora;

		private Wypo¿yczenie wypo¿yczenie;
		private Lista_rezerwacji lista_rezerwacji;

	}

}
