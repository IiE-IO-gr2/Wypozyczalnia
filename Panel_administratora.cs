using System;
namespace logika_biznesowa {
	public class Panel_administratora {
		/// <summary>
		/// login admina, aby zalogowa� si� do systemu
		/// </summary>
		public string Login;
		/// <summary>
		/// has�o admina, aby zalogowa� si� do systemu
		/// </summary>
		private string haslo;

		/// <summary>
		/// metoda zalogowania si� do systemu
		/// </summary>
		public void ZalogujSie() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda wylogowania si� z systemu
		/// </summary>
		public void WylogujSie() {
			throw new System.Exception("Not implemented");
		}

		private Klient klient;
		private Rezerwacja rezerwacja;
		private Samoch�d samoch�d;
		private Rozliczenie rozliczenie;

	}

}
