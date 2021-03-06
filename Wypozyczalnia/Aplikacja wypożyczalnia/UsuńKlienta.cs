﻿using System;
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
    public partial class UsuńKlienta : Form
    {
        public UsuńKlienta()
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
        /// Przycisk umożliwiający usunięcie danych klienta z bazy
        /// </summary>
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
                int id1 = int.Parse(textBox1.Text);

                try
                {
                    int id = int.Parse(textBox1.Text);
                    string exmsg = Klient.UsunKlienta(id);
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        MessageBox.Show("Wystąpił błąd:\n" + exmsg);
                    else
                    {
                        MessageBox.Show("Usunięto klienta z bazy");
                        textBox1.Clear();
                        //this.Hide();
                        //UsuńKlienta uk = new UsuńKlienta();
                        //uk.Show();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd:\nNiepoprawny lub pusty numer identyfikacyjny");
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
    }
}
