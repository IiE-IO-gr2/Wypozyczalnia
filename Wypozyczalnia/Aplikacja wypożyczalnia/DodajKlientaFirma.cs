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
    public partial class DodajKlientaFirma : Form
    {
        public DodajKlientaFirma()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RodzajKlienta rk = new RodzajKlienta();
            rk.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /// Sprawdzenie poprawności danych w textboxach
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            MessageBox.Show("Dlugosc = " + textBox2.Text.Length);
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^([A-Za-z0-9\-]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu nazwa";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^[0-9]{10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu NIP";
                poprawneTextboxy = false;
            }
            //
            // DOPISAĆ DLA RESZTY PÓL
            //
            if (poprawneTextboxy == true)
            {
                /// Pobranie danych z TextBoxów
                int id = Klient.MaksymalnyNumerIdentyfikatoraWBazie() + 1;
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

        private void DodajKlientaFirma_Load(object sender, EventArgs e)
        {

        }
    }
}
