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
    public partial class DodajKlientaIndywidualny : Form
    {
        public DodajKlientaIndywidualny()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /// Sprawdzenie poprawności danych w textboxach
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            MessageBox.Show("Dlugosc = " + textBox2.Text.Length);
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^([A-Za-ząęłóżćśźń]){2,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu imię";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^[A-Za-ząęłóżćśźń]{2,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu nazwisko";
                poprawneTextboxy = false;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text) ||
               !System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"^[A-Za-z0-9\-]{2,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu numer prawa jazdy";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text) ||
               !System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^[0-9]{11}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu PESEL";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, @"^[A-Za-ząęłóżćśźń]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu płeć";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox7.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, @"^[0-9]{9,11}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu telefon";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox8.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, @"^[A-Za-z0-9\- ,.-ąęłóżćśźń]{2,50}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu adres zamieszkania";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox9.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, @"^[A-Za-z0-9\-,.@]{2,50}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu adres e-mail";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox10.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, @"^[0-9,.]{1,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu promocja";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox11.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, @"^[0-9]{1,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu aktywność";
                poprawneTextboxy = false;
            }

            if (poprawneTextboxy == true)
            {
                /// Pobranie danych z TextBoxów
                //int id = int.Parse(textBox1.Text);
                int id = Klient.MaksymalnyNumerIdentyfikatoraWBazie() + 1;
                string imie = textBox2.Text;
                string nazw = textBox3.Text;
                string nr = textBox4.Text;
                string psl = textBox5.Text;
                bool pl = false;
                if (textBox6.Text == "K")
                    pl = true;
                string tl = textBox7.Text;
                string ad = textBox8.Text;
                string em = textBox9.Text;
                double pr = double.Parse(textBox10.Text);
                int ak = int.Parse(textBox11.Text);

                /// Stworzenie obiektów reprezentujących podane dane
                Klient klient1 = new Klient(id, tl, ad, em, pr, ak);
                Klient_indywidualny klientIndywidualny1 =
                    new Klient_indywidualny(imie, nazw, nr, psl, pl);

                string exmsg_kl = klient1.DodanieKlienta();
                string exmsg_ind = klientIndywidualny1.DodajKlientaIndywidualnegoDoBazy(klient1.Id_klienta);
                if (string.IsNullOrWhiteSpace(exmsg_kl))
                    MessageBox.Show("Dodano klienta do bazy");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_kl);
                if (string.IsNullOrWhiteSpace(exmsg_ind))
                    MessageBox.Show("Dodano połączenie oraz klienta indywidualnego do bazy");
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

        private void WsteczWS_Click(object sender, EventArgs e)
        {
            this.Hide();
            RodzajKlienta rk = new RodzajKlienta();
            rk.Show();
        }
    }
}
