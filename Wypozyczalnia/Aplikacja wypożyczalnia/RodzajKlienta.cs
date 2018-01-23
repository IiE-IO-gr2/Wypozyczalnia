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
    public partial class RodzajKlienta : Form
    {
        public RodzajKlienta()
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
            this.Hide();
            DodajKlientaIndywidualny dki = new DodajKlientaIndywidualny();
            dki.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajKlientaFirma dkf = new DodajKlientaFirma();
            dkf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajKlientaIndywidualny dki = new DodajKlientaIndywidualny();
            dki.Show();
        }

        private void WsteczWS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci k = new Klienci();
            k.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajKlientaFirma dkf = new DodajKlientaFirma();
            dkf.Show();
        }
    }
}
