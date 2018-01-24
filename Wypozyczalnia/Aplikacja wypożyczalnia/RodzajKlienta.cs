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
        /// Przycisk umożliwiający przejście do formularza Dodaj Klienta - Klient Indywidualny
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajKlientaIndywidualny dki = new DodajKlientaIndywidualny();
            dki.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Dodaj Klienta - Firma
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajKlientaFirma dkf = new DodajKlientaFirma();
            dkf.Show();
        }

        
    }
}
