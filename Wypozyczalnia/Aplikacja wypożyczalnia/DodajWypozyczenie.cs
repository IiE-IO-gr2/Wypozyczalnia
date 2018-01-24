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
            int id = Wypożyczenie.MaksymalnyNumerIdentyfikatoraWBazie() + 1;
            // Tu chciałam obliczyć ilość dni, później trzeba to pomnożyć przez cenę za dobę 
            // i mamy wartość wypożyczenia
            //
            DateTime dts = dateTimePicker1.Value.Date;
            DateTime dte = dateTimePicker2.Value.Date;
            TimeSpan ts = dte - dts;
            int days = ts.Days;
            textBox1.Text = (Wypożyczenie.MaksymalnyNumerIdentyfikatoraWBazie() + 1).ToString();
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            // sprawdzanie poprwnosci
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
            if (string.IsNullOrWhiteSpace(textBox5.Text) ||
               !System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu cena za dobę";
                poprawneTextboxy = false;
            }
            if (poprawneTextboxy == true)
            {
                /// Pobranie danych z TextBoxów
                int id = Wypożyczenie.MaksymalnyNumerIdentyfikatoraWBazie() + 1;
                string nazwa = textBox2.Text;
                string nip = textBox5.Text;
                string tl = textBox7.Text;
                string ad = textBox8.Text;
                string em = textBox9.Text;
                double pr = double.Parse(textBox10.Text);
                int ak = int.Parse(textBox11.Text);
                /// Stworzenie obiektów reprezentujących podane dane
                Klient klient1 = new Klient(id, tl, ad, em, pr, ak);
                Klient_firmy klientFirma1 =
                    new Klient_firmy(nazwa, nip);
                string exmsg_kl = klient1.DodanieKlienta();
                string exmsg_ind = klientFirma1.DodajKlientaFirmeDoBazy(klient1.Id_klienta);
                if (string.IsNullOrWhiteSpace(exmsg_kl))
                    MessageBox.Show("Dodano klienta do bazy");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_kl);
                if (string.IsNullOrWhiteSpace(exmsg_ind))
                    MessageBox.Show("Dodano połączenie oraz klienta-firmę do bazy");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_ind);
            }
            else
            {
                MessageBox.Show("Wystąpiły błędy w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }

        }
    }
}
       

