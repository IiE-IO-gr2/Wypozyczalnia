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
    public partial class WyszukajKlienta : Form
    {
        public WyszukajKlienta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk umożliwiający powrót do formularza Klienci
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci k = new Klienci();
            k.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający wyszukanie i wyświetlenie danych klienta
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DataTable();
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
                /// Wyszukanie klienta w bazie o podanym ID
                int id = int.Parse(textBox1.Text);
                string exmsg = "";
                DataTable dt = Klient.WyszukajKlienta(id, ref exmsg);
                if (!string.IsNullOrWhiteSpace(exmsg))
                {
                    MessageBox.Show("Wystąpił błąd: " + exmsg);
                }
                else
                {
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                /// Wyświetlenie informacji o błędzie
                MessageBox.Show("Wystąpił błąd w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
