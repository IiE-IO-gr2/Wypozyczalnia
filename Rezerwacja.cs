using System;
namespace logika_biznesowa {
	public class Rezerwacja {
		/// <summary>
		/// numer id rezerwacji
		/// </summary>
		public int ID_rezerwacji;
		/// <summary>
		/// data, na jak� klient planuje wypo�yczy� samoch�d
		/// </summary>
		public string Data_planowanego_wypozyczenia;
		/// <summary>
		/// data, kiedy klient planuje odda� samoch�d
		/// </summary>
		public string Data_planowanego_zwrotu;

		/// <summary>
		/// metoda, kt�ra pokazuje rezerwacj�
		/// </summary>
		public void PokazRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, kt�ra edytuje rezerwacj�
		/// </summary>
		public void EdytujRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, kt�ra dodaje rezerwacj�
		/// </summary>
		public void DodajRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, kt�ra usuwa rezerwacj�
		/// </summary>
		public void UsunRezerwacje() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// metoda, kt�ra wyszukuje rezerwacj�
		/// </summary>
		public void WyszukajRezerwacje() {
			throw new System.Exception("Not implemented");
		}

		private Samoch�d samoch�d;
		private Klient klient;
		private Panel_administratora panel administratora;

		private Wypo�yczenie wypo�yczenie;
		private Lista_rezerwacji lista_rezerwacji;

	}

}
