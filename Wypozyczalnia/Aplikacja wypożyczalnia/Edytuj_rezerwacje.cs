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
    public partial class Edytuj_rezerwacje : Form
    {
        public Edytuj_rezerwacje()
        {
            InitializeComponent();
        }

        private void rezerwacje_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///Przycisk powraca do poprzedniej sekcji
        /// </summary>
        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacje re = new Rezerwacje();
            re.Show();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///Przycisk wyszukuje rezerwację do edycji oraz otwiera okno, w którym można edytować parametry rezerwacji
        ///</summary>
        private void button3_Click(object sender, EventArgs e)
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
                DataTable dt = Rezerwacja.WyszukajRezerwacje(id, ref exmsg);
                if (!string.IsNullOrEmpty(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n\t-" + exmsg);
                else
                {
                    /// <summary>
                    /// opcja otwiera okno edycji z wszystkimi parametrami rezerwacji
                    /// </summary>
                    
                    //PokazWyszukiwanaRezerwacje  pwr = new PokazWyszukiwanaRezerwacje(dt);
                    //pwr.Show();
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
