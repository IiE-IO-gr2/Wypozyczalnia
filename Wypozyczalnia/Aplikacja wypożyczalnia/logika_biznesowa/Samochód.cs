using System;
namespace logika_biznesowa {
	public class Samochód {
		/// <summary>
		/// numer id samochodu
		/// </summary>
		public int Id_samochodu;
		/// <summary>
		/// marka samochodu
		/// </summary>
		public string Marka;
		/// <summary>
		/// model samochodu
		/// </summary>
		public string Model;
		/// <summary>
		/// pojemnoœæ silnika samochodu
		/// </summary>
		public double Pojemnosc;
		/// <summary>
		/// rodzaj paliwa w samochodzie
		/// </summary>
		public string Rodzaj_paliwa;
		/// <summary>
		/// typ nadwozia samochodu
		/// </summary>
		public string Typ_nadwozia;
		/// <summary>
		/// iloœæ koni mechanicznych w samochodzie
		/// </summary>
		public int Ilosc_koni;
		/// <summary>
		/// skrzynia biegów w samochodzie (manualna/automatyczna)
		/// </summary>
		public string Skrzynia_biegow;
		/// <summary>
		/// iloœæ biegów w samochodzie
		/// </summary>
		public int Ilosc_biegów;
		/// <summary>
		/// zu¿ycie paliwa samochodu na 100km
		/// </summary>
		public double Zu¿ycie_paliwa;
		/// <summary>
		/// iloœæ miejsc w samochodzie
		/// </summary>
		public int Ilosc_miejsc;
		/// <summary>
		/// iloœæ drzwi w samochodzie
		/// </summary>
		public int Ilosc_drzwi;
		/// <summary>
		/// rok produkcji samochodu
		/// </summary>
		public int Rocznik;
		/// <summary>
		/// kolor samochodu
		/// </summary>
		public string Kolor;
		/// <summary>
		/// cena za dobê wypo¿yczenia samochodu
		/// </summary>
		public double Cena_za_dobê;
		/// <summary>
		/// czy samochód jest dostêpny w wypo¿yczalni
		/// </summary>
		public bool Dostepnosc;
		/// <summary>
		/// inne uwagi
		/// </summary>
		public string Inne;
		/// <summary>
		/// kaucja zwrotna za samochód p³atna przy wypo¿yczeniu pod warunkiem, ¿e nie dokonano ¿adnych uszkodzeñ
		/// </summary>
		public int Kaucja;

		/// <summary>
		/// metoda dodaj¹ca samochód do bazy
		/// </summary>
		public void DodajSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda edytuj¹ca samochód w bazie
		/// </summary>
		public void EdytujSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda usuwaj¹ca samochód z bazy
		/// </summary>
		public void UsunSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda wyszukuj¹ca samochód w bazie
		/// </summary>
		public void WyszukajSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda sprawdzaj¹ca czy samochód jest dostêpny w bazie
		/// </summary>
		public bool CzyDostepny() {
			throw new System.Exception("Not implemented");
		}

		private Panel_administratora panel_administratora;

		private Rezerwacja rezerwacja;

	}

}
