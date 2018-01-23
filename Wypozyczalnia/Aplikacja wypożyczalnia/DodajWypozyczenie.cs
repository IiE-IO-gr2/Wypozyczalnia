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
    public partial class DodajWypozyczenie : Form
    {
        public DodajWypozyczenie()
        {
            InitializeComponent();
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
