using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_wypożyczalnia
{
    public partial class Dodaj_rezerwacje : Form
    {
        public Dodaj_rezerwacje()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void rezerwacje_Click(object sender, EventArgs e)
        {

        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacja re = new Rezerwacja();
            re.Show();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Do przetestowania!
            DateTime dataPlanowanegoWypozyczenia = dateTimePicker1.Value;
            if (dataPlanowanegoWypozyczenia.CompareTo(DateTime.Today) == -1)
            {
                MessageBox.Show("Nie można podać minionej daty.");
            }

            /// Sprawdzenie poprawności danych w textboxach
            string bladWTextboxach = "";
            bool poprawneTextboxy = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[0-9]{1,10}$" ))
            {
                bladWTextboxach += "\n\t-Błędna lub pusta wartość w polu ID rezerwacji";
                poprawneTextboxy = false;
            }
            else
            {
                MessageBox.Show("Wystąpiły błędy w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
