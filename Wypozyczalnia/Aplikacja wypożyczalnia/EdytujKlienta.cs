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
    public partial class EdytujKlienta : Form
    {
        public EdytujKlienta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci k = new Klienci();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (poprawneTextboxy == true)
            {
                /// Pobranie danych z TextBoxa
                int id = int.Parse(textBox1.Text);
                string exmsg = "";
                DataTable dt = Klient.WyszukajKlienta(id, ref exmsg);
                if (!string.IsNullOrEmpty(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n\t-" + exmsg);
                else
                {
                    if (dt.Columns.Count == 8) // mamy do czynienia z klientem-firmą
                    {
                        PokazWyszukanegoKlientaFirme pwkf = new PokazWyszukanegoKlientaFirme(dt);
                        pwkf.Show();
                    }
                    else // mamy do czynienia z klientem indywidualnym
                    {
                        PokazWyszukanegoKlientaIndywidualnego pwki = new PokazWyszukanegoKlientaIndywidualnego(dt);
                        pwki.Show();
                    }
                }               
            }
            else
            {
                MessageBox.Show("Wystąpił błąd w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }

        }

        
    }
}
