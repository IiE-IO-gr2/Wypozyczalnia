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
    public partial class UsunWypozyczenie : Form
    {
        public UsunWypozyczenie()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Przycisk umożliwiający powrót do poprzedniego okna
        /// </summary>
        private void Wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }
        /// <summary>
        ///Przycisk umożliwiający wyszukanie wypożyczenia i usunięcie go z bazdy danych
        /// </summary>
        private void Button2_Click(object sender, EventArgs e)
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
                int id1 = int.Parse(textBox1.Text);

                try
                {
                    int id = int.Parse(textBox1.Text);
                    string exmsg = Wypożyczenie.UsunWypozyczenie(id);
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        MessageBox.Show("Wystąpił błąd:\n" + exmsg);
                    else
                    {
                        MessageBox.Show("Usunięto wypożyczenie z bazy");
                        textBox1.Clear();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd:\nNiepoprawny lub pusty numer identyfikacyjny");
                }
            }
        }
    }
}
