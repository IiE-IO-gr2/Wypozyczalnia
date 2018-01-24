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
        /// <summary>
        ///Przycisk, który cofa do poprzedniej sekcji czyli Samochody
        /// </summary>
        private void WsteczES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody es = new Samochody();
            es.Show();
        }
        /// <summary>
        ///Przycisk wyszukuje samochodu do edycji oraz pojawia się okno, w którym można edytować wszystkie, bądź wybrane parametry samochodu
        /// </summary>
        private void ZatwierdźES_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Sprawdzenie poprawności danych w textboxie
            /// </summary>
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
                /// <summary>
                /// Pobranie danych z TextBoxa
                /// </summary>
                int id = int.Parse(textBox1.Text);
                string exmsg = "";
                DataTable dt = Samochód.WyszukajSamochod(id, ref exmsg);
                if (!string.IsNullOrEmpty(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n\t-" + exmsg);
                else
                {
                    /// <summary>
                    //opcja otwiera okno edycji z wszystkimi parametrami samochodu
                    /// </summary>
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

        private void EdytujSamochód_Load(object sender, EventArgs e)
        {

        }
    }
}
