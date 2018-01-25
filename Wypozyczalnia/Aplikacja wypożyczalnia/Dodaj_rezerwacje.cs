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
    public partial class Dodaj_rezerwacje : Form
    {
        public Dodaj_rezerwacje()
        {
            InitializeComponent();
            textBox1.Text = (Rezerwacja.MaksymalnyNumerIdentyfikatoraWBazie() + 1).ToString();
        }
        
        private void rezerwacje_Click(object sender, EventArgs e)
        {

        }

        // Do przetestowania!
        // DateTime dataPlanowanegoWypozyczenia = dateTimePicker1.Value;
        //   if (dataPlanowanegoWypozyczenia.CompareTo(DateTime.Today) == -1)
        //  {
        //      MessageBox.Show("Nie można podać minionej daty.");
        //  }

        /// <summary>
        ///Przycisk umożliwiający powrót do poprzedniego okna
        /// </summary>
        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacje re = new Rezerwacje();
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (WybierzSamoch ws = new WybierzSamoch())
            {
                if (ws.ShowDialog() == DialogResult.OK)
                {
                    textBox4.Text = ws.PobraneIDSamWartosc;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }
        }

        /// <summary>
        ///Przycisk umożliwiający wybranie klienta biznesowego do rezerwacji
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            using (WybierzKlienta wk = new WybierzKlienta())
            {
                if (wk.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = wk.PobraneIDKlientaWartosc;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///Przycisk umożliwiający wybranie klienta indywidualnego do rezerwacji
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            using (WybierzKlientaIndywidualnego wki = new WybierzKlientaIndywidualnego())
            {
                if (wki.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = wki.PobraneIDKlientaWartosc;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }
        }

        /// <summary>
        ///Przycisk umożliwiający dodanie rezerwacji do bazy
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
                int id_rez = int.Parse(textBox1.Text);
                int id_kli = int.Parse(textBox3.Text);
                int id_sam = int.Parse(textBox4.Text);
                /// Stworzenie obiektu reprezentującego podane dane
                Rezerwacja rezerwacja1 = new Rezerwacja(id_rez, dataPlanowanegoWypozyczenia, dataPlanowanegoZwrotu);
                string exmsg_wyp = rezerwacja1.DodajRezerwacje();
                if (string.IsNullOrWhiteSpace(exmsg_wyp))
                    MessageBox.Show("Dodano rezerwację do bazy");
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
