using System;
namespace logika_biznesowa {
	public class Rozliczenie {
		/// <summary>
		/// data zwrotu samochodu
		/// </summary>
		public string Data_zwrotu;
		/// <summary>
		/// sprawdzenie, czy samoch�d jest uszkodzony
		/// </summary>
		public bool Czy_uszkodzony;

		/// <summary>
		/// metoda wyliczaj�ca ca�kowit� cen� za wypo�yczenie
		/// </summary>
		public void WyliczCene() {
			throw new System.Exception("Not implemented");
		}

		private Wypo�yczenie wypo�yczenie;
		private Panel_administratora panel administratora;

	}

}
