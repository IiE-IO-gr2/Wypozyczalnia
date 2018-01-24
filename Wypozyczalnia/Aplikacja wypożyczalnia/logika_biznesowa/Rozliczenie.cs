using System;
using System.Data;

namespace logika_biznesowa
{
    public class Rozliczenie
    {
        /// <summary>
        /// data zwrotu samochodu
        /// </summary>
        public DateTime Data_zwrotu;
        /// <summary>
        /// sprawdzenie, czy samochód jest uszkodzony
        /// </summary>
        public bool Czy_uszkodzony;

        /// <summary>
        /// Konstruktor rozliczenia
        /// </summary>
        /// <param name="_Data_zwrotu">faktyczna data zwrotu samochodu</param>
        /// <param name="_Czy_uszkodzony">czy samochód zosta³ uszkodzony (tak/nie)</param>
        public Rozliczenie(DateTime _Data_zwrotu, bool _Czy_uszkodzony)
        {
            Data_zwrotu = _Data_zwrotu;
            Czy_uszkodzony = _Czy_uszkodzony;
        }

        /// <summary>
        /// metoda wyliczaj¹ca ca³kowit¹ cenê za wypo¿yczenie i aktualizuj¹ca dane w bazie
        /// </summary>
        public double WyliczCene(DataTable dt, ref string test)
        {
            int idWypozyczenia = -1;
            string dataWypozyczeniaSTR = "";
            string dataPlanowanegoZwrotuSTR = "";
            double promocja = 0.0;
            int aktywnosc = 0;
            double cenaZaDobe = -1;
            foreach (DataRow item in dt.Rows)
            {
                idWypozyczenia = int.Parse(item[0].ToString());
                dataPlanowanegoZwrotuSTR = item[1].ToString();
                dataWypozyczeniaSTR = item[2].ToString();
                promocja = double.Parse(item[3].ToString());
                aktywnosc = int.Parse(item[4].ToString());
                cenaZaDobe = double.Parse(item[5].ToString());
            }
            // Czas trwania wypozyczenia
            string dw_rok = string.Concat(dataWypozyczeniaSTR[0], dataWypozyczeniaSTR[1], dataWypozyczeniaSTR[2], dataWypozyczeniaSTR[3]);
            string dw_m = string.Concat(dataWypozyczeniaSTR[5], dataWypozyczeniaSTR[6]);
            string dw_d = string.Concat(dataWypozyczeniaSTR[8], dataWypozyczeniaSTR[9]);
            string dz_rok = string.Concat(dataPlanowanegoZwrotuSTR[0], dataPlanowanegoZwrotuSTR[1], dataPlanowanegoZwrotuSTR[2], dataPlanowanegoZwrotuSTR[3]);
            string dz_m = string.Concat(dataPlanowanegoZwrotuSTR[5], dataPlanowanegoZwrotuSTR[6]);
            string dz_d = string.Concat(dataPlanowanegoZwrotuSTR[8], dataPlanowanegoZwrotuSTR[9]);
            DateTime dataWypozyczenia = new DateTime(int.Parse(dw_rok), int.Parse(dw_m), int.Parse(dw_d));
            DateTime dataPlanowanegoZwrotu = new DateTime(int.Parse(dz_rok), int.Parse(dz_m), int.Parse(dz_d));
            TimeSpan dlugoscWypozyczenia = Data_zwrotu - dataWypozyczenia;
            int dobyWypozyczenia = (int)Math.Ceiling(dlugoscWypozyczenia.TotalHours) / 24 + 1;
            // wyliczenie ceny
            if (dataPlanowanegoZwrotu.CompareTo(Data_zwrotu) == 1 && Czy_uszkodzony == false && aktywnosc != 0 && aktywnosc % 5 == 0)
            {
                return (cenaZaDobe * dobyWypozyczenia * (1 - promocja));
            }
            else
            {
                return (cenaZaDobe * dobyWypozyczenia);
            }
        }
    }
}
