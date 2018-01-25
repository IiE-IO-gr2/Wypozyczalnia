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
    public partial class DodajWypozyczenie : Form
    {
        public DodajWypozyczenie()
        {
            InitializeComponent();
            textBox1.Text = (Wypożyczenie.MaksymalnyNumerIdentyfikatoraWBazie() + 1).ToString();
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
        ///Przycisk umożliwiający wybranie samochodu do wypożyczenia
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            using (WybierzSamoch ws = new WybierzSamoch())
            {
                if (ws.ShowDialog() == DialogResult.OK)
                {
                    textBox4.Text = ws.PobraneIDSamWartosc;
                    textBox5.Text = ws.KwotaWart;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }
        }
        /// <summary>
        ///Przycisk umożliwiający wybranie klienta biznesowego do wypożyczenia
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            using (WybierzKlienta wk = new WybierzKlienta())
            {
                if (wk.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = wk.PobraneIDKlientaWartosc;
                    textBox6.Text = wk.PobranaZnizkaLojalnosciowa;
                    textBox7.Text = wk.PobranaIloscWypozyczen;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }

        }
        /// <summary>
        ///Przycisk umożliwiający wybranie klienta indywidualnego do wypożyczenia
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            using (WybierzKlientaIndywidualnego wki = new WybierzKlientaIndywidualnego())
            {
                if (wki.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = wki.PobraneIDKlientaWartosc;
                    textBox6.Text = wki.PobranaZnizkaLojalnosciowaIND;
                    textBox7.Text = wki.PobranaIloscWypozyczenIND;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }
        }
        /// <summary>
        ///Przycisk umozliwiający dodanie wypożyczenia do bazy
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            // sprawdzanie poprawnosci
            DateTime dataPlanowanegoWypozyczenia = dateTimePicker1.Value;
            DateTime dataPlanowanegoZwrotu = dateTimePicker2.Value;
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ID klienta";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ID Samochodu";
                poprawneTextboxy = false;
            }
            if (dataPlanowanegoWypozyczenia.CompareTo(DateTime.Today) == -1)
            {
                bladWTextboxach += "\n\t-Początek wypożyczenia nie możne być minioną datą";
                poprawneTextboxy = false;
            }
            if (dataPlanowanegoZwrotu.CompareTo(DateTime.Today) == -1)
            {
                bladWTextboxach += "\n\t-Data zwrotu nie może być minioną datą";
                poprawneTextboxy = false;
            }
            if (poprawneTextboxy == true)
            {
                /// Pobranie danych z TextBoxów
                int id_wyp = int.Parse(textBox1.Text);
                int id_kli = int.Parse(textBox3.Text);
                int id_sam = int.Parse(textBox4.Text);
                double znizkaLojaln = double.Parse(textBox6.Text);
                int liczbaWypozyczen = (int)double.Parse(textBox7.Text);
                double cena_za_dobe = double.Parse(textBox5.Text);
                if (liczbaWypozyczen % 5 == 0 & liczbaWypozyczen != 0)
                    cena_za_dobe *= (1 - znizkaLojaln);
                TimeSpan dlugoscWypozyczenia = dataPlanowanegoZwrotu - dataPlanowanegoWypozyczenia;
                int dobyWypozyczenia = (int)Math.Ceiling(dlugoscWypozyczenia.TotalHours) / 24 + 1;
                double cena_wypozyczenia = cena_za_dobe * dobyWypozyczenia;
                textBox2.Text = cena_wypozyczenia.ToString();
                /// Stworzenie obiektu reprezentującego podane dane
                Wypożyczenie wypożyczenie1 = new Wypożyczenie(id_wyp, dataPlanowanegoWypozyczenia, dataPlanowanegoZwrotu, cena_wypozyczenia, id_kli, id_sam);
                string exmsg_wyp = wypożyczenie1.DodajWypozyczenie();
                if (string.IsNullOrWhiteSpace(exmsg_wyp))
                    MessageBox.Show("Dodano wypożyczenie do bazy");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_wyp);
            }
            else
            {
                MessageBox.Show("Wystąpiły błędy w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }

        private void DodajWypozyczenie_Load(object sender, EventArgs e)
        {

        }
    }
}
       

