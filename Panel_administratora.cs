using System;
namespace logika_biznesowa {
	public class Panel_administratora {
		/// <summary>
		/// login admina, aby zalogowaæ siê do systemu
		/// </summary>
		public string Login;
		/// <summary>
		/// has³o admina, aby zalogowaæ siê do systemu
		/// </summary>
		private string haslo;

		/// <summary>
		/// metoda zalogowania siê do systemu
		/// </summary>
		public void ZalogujSie() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda wylogowania siê z systemu
		/// </summary>
		public void WylogujSie() {
			throw new System.Exception("Not implemented");
		}

		private Klient klient;
		private Rezerwacja rezerwacja;
		private Samochód samochód;
		private Rozliczenie rozliczenie;

	}

}
