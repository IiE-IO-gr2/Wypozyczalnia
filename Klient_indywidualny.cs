using System;
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

		private Wypo¿yczenie wypo¿yczenie;

	}

}
