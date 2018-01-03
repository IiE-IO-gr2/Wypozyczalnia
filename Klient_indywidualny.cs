using System;
namespace logika_biznesowa {
	public class Klient_indywidualny : Klient  {
		/// <summary>
		/// imi� klienta indywidualnego
		/// </summary>
		public string Imi�;
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
		/// p�e� klienta indywidualnego
		/// </summary>
		public bool P�ec;

		private Wypo�yczenie wypo�yczenie;

	}

}
