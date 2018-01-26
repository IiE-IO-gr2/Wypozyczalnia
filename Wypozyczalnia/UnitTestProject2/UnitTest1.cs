using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aplikacja_wypożyczalnia;
using logika_biznesowa;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// test sprawdzajacy dodawanie klienta do bazy i usuwanie tego samego klienta
        /// </summary>
        [TestMethod]
        public void TestDodawaniaUsuwaniaKlienta()
        {
            Klient klient = new Klient();
            klient.Id_klienta = 11;
            klient.Telefon_kontaktowy = "123123123";
            klient.Adres = "kwiatkowa 12";
            klient.Adres_email = "aaa@aaa.pl";
            klient.Promocja = 0.2;
            klient.Aktywnosc = 0;
            klient.DodanieKlienta();

            //pusta pętla
            for (int i = 0; i < 10000; i++)
            {
            }

            string aktualny;

            aktualny = Klient.UsunKlienta(11);
            
            string oczekiwany = "";
            Assert.AreEqual(oczekiwany, aktualny);
        }
        
        /// <summary>
        /// test sprawdzajacy dodawanie rezerwacji do bazy i usuwanie tej samej rezerwacji
        /// </summary>
        [TestMethod]
        public void TestDodawaniaUsuwaniaRezerwacji()
        {
            //dodanie klienta
            Klient klient = new Klient();
            klient.Id_klienta = 11;
            klient.Telefon_kontaktowy = "123123123";
            klient.Adres = "kwiatkowa 12";
            klient.Adres_email = "aaa@aaa.pl";
            klient.Promocja = 0.2;
            klient.Aktywnosc = 0;
            klient.DodanieKlienta();

            //dodanie samochodu
            logika_biznesowa.Samochód samochod = new logika_biznesowa.Samochód();
            samochod.Id_samochodu = 1;
            samochod.Marka = "Opel";
            samochod.Model = "Astra";
            samochod.Pojemnosc = 4.2;
            samochod.Rodzaj_paliwa = "benzyna";
            samochod.Typ_nadwozia = "Hatchback";
            samochod.Ilosc_koni = 90;
            samochod.Skrzynia_biegow = "manualna";
            samochod.Ilosc_biegów = 6;
            samochod.Zużycie_paliwa = 7.0;
            samochod.Ilosc_miejsc = 5;
            samochod.Ilosc_drzwi = 5;
            samochod.Rocznik = 2005;
            samochod.Kolor = "czarny";
            samochod.Cena_za_dobę = 100.0;
            samochod.Dostepnosc = false;
            samochod.Inne = "";
            samochod.Kaucja = 200;
            samochod.DodajSamochod();

            //dodanie rezerwacji
            logika_biznesowa.Rezerwacja rezerwacja = new logika_biznesowa.Rezerwacja();
            rezerwacja.ID_rezerwacji = 123;
            rezerwacja.Data_planowanego_wypozyczenia = new DateTime(2018, 2, 1);
            rezerwacja.Data_planowanego_zwrotu = new DateTime(2008, 2, 11);
            rezerwacja.id_samochodu = 1;
            rezerwacja.id_klienta = 11;
            rezerwacja.DodajRezerwacje();

            for (int i = 0; i < 10000; i++)
            {
            }

            string aktualny;

            aktualny = logika_biznesowa.Rezerwacja.UsunRezerwacje(123);
            
            string oczekiwany = "";
            Assert.AreEqual(oczekiwany, aktualny);
        }

        /// <summary>
        /// test sprawdzajacy usuwanie nieistniejącej rezerwacji
        /// </summary>
        [TestMethod]
        public void TestDodawaniaUsuwaniaInnychRezerwacji()
        {
            //dodanie klienta
            Klient klient = new Klient();
            klient.Id_klienta = 11;
            klient.Telefon_kontaktowy = "123123123";
            klient.Adres = "kwiatkowa 12";
            klient.Adres_email = "aaa@aaa.pl";
            klient.Promocja = 0.2;
            klient.Aktywnosc = 0;
            klient.DodanieKlienta();

            //dodanie samochodu
            logika_biznesowa.Samochód samochod = new logika_biznesowa.Samochód();
            samochod.Id_samochodu = 1;
            samochod.Marka = "Opel";
            samochod.Model = "Astra";
            samochod.Pojemnosc = 4.2;
            samochod.Rodzaj_paliwa = "benzyna";
            samochod.Typ_nadwozia = "Hatchback";
            samochod.Ilosc_koni = 90;
            samochod.Skrzynia_biegow = "manualna";
            samochod.Ilosc_biegów = 6;
            samochod.Zużycie_paliwa = 7.0;
            samochod.Ilosc_miejsc = 5;
            samochod.Ilosc_drzwi = 5;
            samochod.Rocznik = 2005;
            samochod.Kolor = "czarny";
            samochod.Cena_za_dobę = 100.0;
            samochod.Dostepnosc = false;
            samochod.Inne = "";
            samochod.Kaucja = 200;
            samochod.DodajSamochod();

            //dodanie rezerwacji
            logika_biznesowa.Rezerwacja rezerwacja = new logika_biznesowa.Rezerwacja();
            rezerwacja.ID_rezerwacji = 123;
            rezerwacja.Data_planowanego_wypozyczenia = new DateTime(2018, 2, 1);
            rezerwacja.Data_planowanego_zwrotu = new DateTime(2008, 2, 11);
            rezerwacja.id_samochodu = 1;
            rezerwacja.id_klienta = 11;
            rezerwacja.DodajRezerwacje();

            for (int i = 0; i < 10000; i++)
            {
            }

            string aktualny;

            aktualny = logika_biznesowa.Rezerwacja.UsunRezerwacje(120);

            string oczekiwany = "";
            Assert.AreNotEqual(oczekiwany, aktualny);
        }

        /// <summary>
        /// test sprawdzajacy dodawanie samochodu do bazy i usuwanie tego samego samochodu
        /// </summary>
        [TestMethod]
        public void TestDodawaniaUsuwaniaSamochodu()
        {
            logika_biznesowa.Samochód samochod = new logika_biznesowa.Samochód();
            samochod.Id_samochodu = 1;
            samochod.Marka = "Opel";
            samochod.Model = "Astra";
            samochod.Pojemnosc = 4.2;
            samochod.Rodzaj_paliwa = "benzyna";
            samochod.Typ_nadwozia = "Hatchback";
            samochod.Ilosc_koni = 90;
            samochod.Skrzynia_biegow = "manualna";
            samochod.Ilosc_biegów = 6;
            samochod.Zużycie_paliwa = 7.0;
            samochod.Ilosc_miejsc = 5;
            samochod.Ilosc_drzwi = 5;
            samochod.Rocznik = 2005;
            samochod.Kolor = "czarny";
            samochod.Cena_za_dobę = 100.0;
            samochod.Dostepnosc = false;
            samochod.Inne = "";
            samochod.Kaucja = 200;
            samochod.DodajSamochod();

            for (int i = 0; i < 10000; i++)
            {
            }

            string aktualny;

            aktualny = logika_biznesowa.Samochód.UsunSamochod(1);

            string oczekiwany = "";
            Assert.AreEqual(oczekiwany, aktualny);

        }
    }
}