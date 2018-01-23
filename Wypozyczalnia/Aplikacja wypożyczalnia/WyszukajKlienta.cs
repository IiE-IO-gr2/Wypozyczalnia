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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci k = new Klienci();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string exmsg = "";
                Klient znaleziony = Klient.WyszukajKlienta(ref exmsg);
                if (!string.IsNullOrWhiteSpace(exmsg))
                    MessageBox.Show("Wystąpił błąd:\n" + exmsg);
                else
                {
                    PokazWyszukanegoKlientaFirme pokazKlientaFirme = new PokazWyszukanegoKlientaFirme();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił błąd:\nNiepoprawny lub pusty numer identyfikacyjny");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
