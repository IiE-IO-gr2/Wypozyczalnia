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
    public partial class UsuńSamochód : Form
    {
        public UsuńSamochód()
        {
            InitializeComponent();
        }

        private void WsteczUS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody us = new Samochody();
            us.Show();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZatwierdźUS_Click_1(object sender, EventArgs e)
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
                    string exmsg = Samochód.UsunSamochod(id);
                    if (!string.IsNullOrWhiteSpace(exmsg))
                        MessageBox.Show("Wystąpił błąd:\n" + exmsg);
                    else
                    {
                        MessageBox.Show("Usunięto samochód z bazy");
                        textBox1.Clear();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd:\nNiepoprawny lub pusty numer identyfikacyjny");
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

