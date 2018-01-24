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
    public partial class PokazWyszukanegoKlientaFirme : Form
    {
        public PokazWyszukanegoKlientaFirme(DataTable dt)
        {
            InitializeComponent();
            foreach (DataRow item in dt.Rows)
            {
                textBox1.Text = item[0].ToString();
                textBox2.Text = item[1].ToString();
                textBox5.Text = item[2].ToString();
                textBox7.Text = item[3].ToString();
                textBox9.Text = item[4].ToString();
                textBox8.Text = item[5].ToString();
                textBox10.Text = item[6].ToString();
                textBox11.Text = item[7].ToString();
                textBox11.Text = item[8].ToString();
                textBox11.Text = item[9].ToString();
                textBox11.Text = item[10].ToString();
                textBox11.Text = item[11].ToString();
            }
        }

        /// <summary>
        /// Przycisk umożliwiający zapisanie edytowanych danych klienta - firmy
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            /// Sprawdzenie poprawności danych w textboxach
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;

            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^([A-Za-z0-9\- ,.-ąęłóżćśźńŁŚĆŻŹ]){2,30}$"))
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
            if (string.IsNullOrWhiteSpace(textBox7.Text) ||
               !System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, @"^[0-9]{3}-[0-9]{3}-[0-9]{3}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu telefon kontaktowy";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox8.Text) ||
              !System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, @"^[A-Za-z0-9\- ,.-ąęłóżćśźńŁŚĆŻŹ]{2,50}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu adres";
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
                int id = int.Parse(textBox1.Text);
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
                string exmsg_kl = klient1.EdytujKlienta();
                string exmsg_fir = klientFirma1.EdytujKlientaFirmeWBazie(klient1.Id_klienta);
                if (string.IsNullOrWhiteSpace(exmsg_kl))
                    MessageBox.Show("Zaktualizowano klienta w bazie");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_kl);
                if (string.IsNullOrWhiteSpace(exmsg_fir))
                    MessageBox.Show("Zaktualizowano klienta-firmę w bazie");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_fir);
            }
            else
            {
                /// Wyświetlenie informacji o błędzie
                MessageBox.Show("Wystąpiły błędy w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }

        /// <summary>
        /// Przycisk umożliwiający zamknięcie okna
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
