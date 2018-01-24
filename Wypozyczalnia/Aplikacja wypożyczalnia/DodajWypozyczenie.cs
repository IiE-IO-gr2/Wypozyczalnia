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
            /// Tu chciałam obliczyć ilość dni, później trzeba to pomnożyć przez cenę za dobę 
            ///i mamy wartość wypożyczenia
            ///
            DateTime dts = dateTimePicker1.Value.Date;
            DateTime dte = dateTimePicker2.Value.Date;
            TimeSpan ts = dte - dts;

            int days = ts.Days;



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
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w cena za wypożyczenie";
                poprawneTextboxy = false;
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
               !System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[0-9]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ID klienta";
                poprawneTextboxy = false;

            }
                    
                

            }
        }
    }
}
       

