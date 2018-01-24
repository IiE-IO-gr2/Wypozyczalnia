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
    public partial class Usun_rezerwacje : Form
    {
        public Usun_rezerwacje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                int id1 = int.Parse(textBox1.Text);

                //zakomentowane, bo nie pokazuje mi metod z logiki biznesowej...:(
                //try
                //{
                    //int id = int.Parse(textBox1.Text);
                   // string exmsg = Rezerwacja.UsunRezerwacje(id);
                    //if (!string.IsNullOrWhiteSpace(exmsg))
                       // MessageBox.Show("Wystąpił błąd:\n" + exmsg);
                   // else
                   // {
                        //MessageBox.Show("Usunięto rezerwację z bazy");
                       // textBox1.Clear();

                   // }
               // }
               // catch (Exception)
                //{
                   // MessageBox.Show("Wystąpił błąd:\nNiepoprawny lub pusty numer identyfikacyjny");
               // }
            }

            else
            {
                MessageBox.Show("Wystąpił błąd w danych wejściowych:" + bladWTextboxach);
                bladWTextboxach = "";
                poprawneTextboxy = true;
            }
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacje re = new Rezerwacje();
            re.Show();
        }
    }
}
