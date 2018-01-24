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
    public partial class EdytujSamochód : Form
    {
        public EdytujSamochód()
        {
            InitializeComponent();
        }

        private void WsteczES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody es = new Samochody();
            es.Show();
        }

        private void ZatwierdźES_Click(object sender, EventArgs e)
        {

            /// Sprawdzenie poprawności danych w textboxie
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;
            //MessageBox.Show("Dlugosc = " + textBox2.Text.Length);
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
                DataTable dt = Samochód.WyszukajSamochod(id, ref exmsg);
                if (!string.IsNullOrEmpty(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n\t-" + exmsg);
                else
                {
                    
                        PokazWyszukiwanySamochod pws = new PokazWyszukiwanySamochod(dt);
                        pws.Show();
                    
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
