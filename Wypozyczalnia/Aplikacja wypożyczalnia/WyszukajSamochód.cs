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
    public partial class WyszukajSamochód : Form
    {
        public WyszukajSamochód()
        {
            InitializeComponent();
        }
        //Przycisk, który cofa do poprzedniej sekcji tj. Samochód
        private void WsteczWS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody ws = new Samochody();
            ws.Show();
        }
        /*Zatwierdza i wyszukuje w bazie samochodu o wpisanym numerze id,
        jeśli samochodu o takim id nie ma w bazie pojawia się odpowiednia informacja.
        */
        private void ZatwierdźWS_Click(object sender, EventArgs e)
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
                int id = int.Parse(textBox1.Text);
                string exmsg = "";
                DataTable dt = Samochód.WyszukajSamochod(id, ref exmsg);
                if (!string.IsNullOrWhiteSpace(exmsg))
                {
                    MessageBox.Show("Wystąpił błąd: " + exmsg);
                }
                else
                {
                    //w oknie pojawia się wyszukiwany samochód ze wszystkimi atrybutami
                    dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WyszukajSamochód_Load(object sender, EventArgs e)
        {

        }
    }
}
