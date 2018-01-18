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
    public partial class DodajSamochód : Form
    {
        public DodajSamochód()
        {
            InitializeComponent();
        }
        
        private void WsteczDS_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            Samochody ds = new Samochody();
            ds.Show();
        }

        private void ZatwierdźDS_Click(object sender, EventArgs e)
        {
            /// Sprawdzenie poprawności danych w textboxach
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            MessageBox.Show("Dlugosc = " + textBox2.Text.Length);
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^([A-Za-z0-9\-]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu marka";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"^([A-Za-z0-9\-]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu model";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^([0-9]){2,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu pojemność";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^([A-Za-z0-9\-]){2,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu rodzaj paliwa";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, @"^([A-Za-z0-9\-]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu typ nadwozia";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox7.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, @"^[0-9]{10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość koni";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox8.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, @"^([A-Za-z0-9\-]){2,30}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu skrzynia biegów";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox9.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, @"^([0-9]){1}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość biegów";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox10.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox10.Text, @"^([0-9]){2,5}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu zużycie paliwa";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox11.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, @"^([0-9]){1,2}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość miejsc";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox12.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox12.Text, @"^([0-9]){1}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ilość drzwi";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox13.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox13.Text, @"^([0-9]){4}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu rocznik";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox14.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox14.Text, @"^([A-Za-z]){2,20}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu kolor";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox15.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox15.Text, @"^([0-9]){2,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu cena za dobę";
                poprawneTextboxy = false;
            }
            if (string.IsNullOrWhiteSpace(textBox18.Text) ||
                  !System.Text.RegularExpressions.Regex.IsMatch(textBox18.Text, @"^([0-9]){2,10}$"))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu kaucja";
                poprawneTextboxy = false;
            }
            if (poprawneTextboxy == true)
            {
                int id = Samochód.MaksymalnyNumerIdentyfikatoraWBazie() + 1;
                string mar = textBox2.Text;
                string mod = textBox4.Text;
                double poj = double.Parse(textBox3.Text);
                string rp = textBox5.Text;
                string tn = textBox6.Text;
                int ik = int.Parse(textBox7.Text);
                string sk = textBox8.Text;
                int ib = int.Parse(textBox9.Text);
                double zp = double.Parse(textBox10.Text);
                int im = int.Parse(textBox11.Text);
                int ilodr = int.Parse(textBox12.Text);
                int roc = int.Parse(textBox13.Text);
                string kol = textBox14.Text;
                double czd = double.Parse(textBox15.Text);
                bool dostep = bool.Parse(textBox16.Text);
                string inne = textBox17.Text;
                int ka = int.Parse(textBox18.Text);

                Samochód samochód1 = new Samochód(id, mar,mod,poj,rp,tn,ik,sk,ib,zp,im,ilodr,roc,kol,czd,dostep,inne,ka);
                
                string exmsg_kl = samochód1.DodajSamochod();
                if (string.IsNullOrWhiteSpace(exmsg_kl))
                    MessageBox.Show("Dodano samochód do bazy");
                else
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg_kl);
               
            }
            else
            {
                MessageBox.Show("Wystąpiły błędy w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
            MessageBox.Show("Dodano samochód");
            this.Hide();
            DodajSamochód dod = new DodajSamochód();
            dod.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
