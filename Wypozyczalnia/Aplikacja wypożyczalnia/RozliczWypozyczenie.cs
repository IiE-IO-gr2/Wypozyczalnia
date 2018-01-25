using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logika_biznesowa;

namespace Aplikacja_wypożyczalnia
{
    public partial class RozliczWypozyczenie : Form
    {
        public RozliczWypozyczenie()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Przycisk umożliwiający powrót do poprzedniego okna
        /// </summary>
        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }
        /// <summary>
        ///Przycisk umożliwiający rozliczenia wypożyczenia
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            /// Sprawdzenie poprawności danych w textboxie
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ID";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
             !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[NTnt]{1}$"))
            {
                MessageBox.Show(textBox2.Text);
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu uszkodzenie";
                poprawneTextboxy = false;
            }
            if (poprawneTextboxy == true)
            {
                /// Pobranie danych z TextBoxa
                int id = int.Parse(textBox1.Text);
                DateTime dataZwrotu = dateTimePicker2.Value;
                bool uszkodzony = (textBox2.Text == "T" || textBox2.Text == "t") ? true : false;
                string exmsgIstnieje = "";
                string zapytanieIstnieje = @"select count(*) from [Wypożyczenie] where ((CzyRozliczone=0 or CzyRozliczone is null) and [ID_wypożyczenia] = " + id + ")";
                string czyIstniejeWBazie = FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanieIstnieje, ref exmsgIstnieje);
                if (czyIstniejeWBazie == "0")
                {
                    MessageBox.Show("Wypozyczenie o podanym adresie ID nie istnieje lub zostało już rozliczone");
                }
                else
                {
                    string exmsg = "";
                    string zapytanie = @"select w.ID_wypożyczenia, w.[Data_wypożyczenia], w.[Data_planowanego_zwrotu],"+
                        @"k.Promocja, k.Aktywnosc, s.Cena_za_dobę, w.[Id_Klienta] from ([dbo].[Wypożyczenie] as w inner join [dbo].[Klient] as k " +
                        @"on w.[Id_Klienta] = k.[Id_Klienta]) inner join [dbo].[Samochód] as s on w.[Id_samochodu] = s.Id_samochodu " +
                        @"where w.[ID_wypożyczenia] = " + id;
                    DataTable dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        MessageBox.Show("Wystąpił błąd:\n\t-" + exmsg);
                    else
                    {
                        /// Sprawdzanie, jaka była data wypożyczenia
                        string dataWypozyczeniaSTR = "";
                        foreach (DataRow item in dt.Rows)
                        {
                            dataWypozyczeniaSTR = item[1].ToString();
                        }
                        string dw_rok = string.Concat(dataWypozyczeniaSTR[0], dataWypozyczeniaSTR[1], dataWypozyczeniaSTR[2], dataWypozyczeniaSTR[3]);
                        string dw_m = string.Concat(dataWypozyczeniaSTR[5], dataWypozyczeniaSTR[6]);
                        string dw_d = string.Concat(dataWypozyczeniaSTR[8], dataWypozyczeniaSTR[9]);
                        DateTime dataWypozyczenia = new DateTime(int.Parse(dw_rok), int.Parse(dw_m), int.Parse(dw_d));
                        if (dataZwrotu.CompareTo(dataWypozyczenia) == -1)
                        {
                            MessageBox.Show("Wysapił błąd w danych wejściowych:\n\t-Data zwrotu nie może być wczesniejsza od daty wypożyczenia");
                        }
                        else
                        {
                            Rozliczenie rozliczenie1 = new Rozliczenie(dataZwrotu, uszkodzony);
                            string test = "";
                            double nowaCena = rozliczenie1.WyliczCene(dt, ref test);
                            if (nowaCena <= 0)
                            {
                                MessageBox.Show("Wystąpił błąd podczas wyliczania ceny");
                            }
                            else
                            {
                                string Data_zwr = dataZwrotu.Year.ToString() + "-" + dataZwrotu.Month.ToString() + "-" + dataZwrotu.Day.ToString();
                                int idKlienta = -1;
                                foreach (DataRow item in dt.Rows)
                                {
                                    idKlienta = int.Parse(item[6].ToString());
                                }
                                string exmsg_update1 = "";
                                string zapytanie_update1 = @"update [dbo].[Wypożyczenie] set[CzyRozliczone] = 1, " +
                                    @"[Data_planowanego_zwrotu] = '" + Data_zwr + "' , [Cena_za_wypozyczenie] = " + nowaCena.ToString() +
                                    @"where[ID_wypożyczenia] = " + id;
                                FunkcjePomicnicze.WstawDaneSQL(zapytanie_update1, ref exmsg_update1);
                                string exmsg_update2 = "";
                                string zapytanie_update2 = @"update [dbo].[Klient] set[Aktywnosc] = [Aktywnosc] + 1" +
                                    @"where[Id_klienta] = " + idKlienta;
                                FunkcjePomicnicze.WstawDaneSQL(zapytanie_update2, ref exmsg_update2);
                                if (!string.IsNullOrWhiteSpace(exmsg_update1))
                                    MessageBox.Show("Wystąpił błąd podczas zmiany danych w wypozyczeniu:\n\t-" + exmsg_update1);
                                if (!string.IsNullOrWhiteSpace(exmsg_update2))
                                    MessageBox.Show("Wystąpił błąd podczas zmiany danych w kliencie:\n\t-" + exmsg_update2);
                                if (string.IsNullOrWhiteSpace(exmsg_update1) & string.IsNullOrWhiteSpace(exmsg_update2))
                                    MessageBox.Show("Wypożyczenie zostało rozliczone.");
                                textBox3.Text = nowaCena.ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                /// Wyświetlenie informacji o błędzie
                MessageBox.Show("Wystąpiły błędy w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }
    }
}
