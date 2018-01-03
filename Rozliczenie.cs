using System;
namespace logika_biznesowa {
	public class Rozliczenie {
		/// <summary>
		/// data zwrotu samochodu
		/// </summary>
		public string Data_zwrotu;
		/// <summary>
		/// sprawdzenie, czy samochód jest uszkodzony
		/// </summary>
		public bool Czy_uszkodzony;

		/// <summary>
		/// metoda wyliczaj¹ca ca³kowit¹ cenê za wypo¿yczenie
		/// </summary>
		public void WyliczCene() {
			throw new System.Exception("Not implemented");
		}

		private Wypo¿yczenie wypo¿yczenie;
		private Panel_administratora panel administratora;

	}

}
