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


        // Do przetestowania!
        // DateTime dataPlanowanegoWypozyczenia = dateTimePicker1.Value;
        //   if (dataPlanowanegoWypozyczenia.CompareTo(DateTime.Today) == -1)
        //  {
        //      MessageBox.Show("Nie można podać minionej daty.");
        //  }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacje re = new Rezerwacje();
            re.Show();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (WybierzSamoch ws = new WybierzSamoch())
            {
                if (ws.ShowDialog() == DialogResult.OK)
                {
                    textBox4.Text = ws.PobraneIDSamWartosc;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WybierzKlienta wk = new WybierzKlienta())
            {
                if (wk.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = wk.PobraneIDKlientaWartosc;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (WybierzKlientaIndywidualnego wki = new WybierzKlientaIndywidualnego())
            {
                if (wki.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = wki.PobraneIDKlientaWartosc;
                }
                else
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
