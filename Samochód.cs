using System;
namespace logika_biznesowa {
	public class Samoch�d {
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
		/// pojemno�� silnika samochodu
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
		/// ilo�� koni mechanicznych w samochodzie
		/// </summary>
		public int Ilosc_koni;
		/// <summary>
		/// skrzynia bieg�w w samochodzie (manualna/automatyczna)
		/// </summary>
		public string Skrzynia_biegow;
		/// <summary>
		/// ilo�� bieg�w w samochodzie
		/// </summary>
		public int Ilosc_bieg�w;
		/// <summary>
		/// zu�ycie paliwa samochodu na 100km
		/// </summary>
		public double Zu�ycie_paliwa;
		/// <summary>
		/// ilo�� miejsc w samochodzie
		/// </summary>
		public int Ilosc_miejsc;
		/// <summary>
		/// ilo�� drzwi w samochodzie
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
		/// cena za dob� wypo�yczenia samochodu
		/// </summary>
		public double Cena_za_dob�;
		/// <summary>
		/// czy samoch�d jest dost�pny w wypo�yczalni
		/// </summary>
		public bool Dostepnosc;
		/// <summary>
		/// inne uwagi
		/// </summary>
		public string Inne;
		/// <summary>
		/// kaucja zwrotna za samoch�d p�atna przy wypo�yczeniu pod warunkiem, �e nie dokonano �adnych uszkodze�
		/// </summary>
		public int Kaucja;

		/// <summary>
		/// metoda dodaj�ca samoch�d do bazy
		/// </summary>
		public void DodajSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda edytuj�ca samoch�d w bazie
		/// </summary>
		public void EdytujSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda usuwaj�ca samoch�d z bazy
		/// </summary>
		public void UsunSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda wyszukuj�ca samoch�d w bazie
		/// </summary>
		public void WyszukajSamochod() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda sprawdzaj�ca czy samoch�d jest dost�pny w bazie
		/// </summary>
		public bool CzyDostepny() {
			throw new System.Exception("Not implemented");
		}

		private Panel_administratora panel administratora;

		private Rezerwacja rezerwacja;

	}

}
