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
    public partial class Klienci : Form
    {
        public Klienci()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk umożliwiający powrót do formularza Menu po zalogowaniu
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Rodzaj Klienta
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RodzajKlienta rk = new RodzajKlienta();
            rk.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Usuń Klienta
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsuńKlienta uk = new UsuńKlienta();
            uk.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Wyszukaj Klienta
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WyszukajKlienta wk = new WyszukajKlienta();
            wk.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Edytuj Klienta
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdytujKlienta ek = new EdytujKlienta();
            ek.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokazKlientow ek = new PokazKlientow();
            ek.Show();
        }



        /*private void WsteczWS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }*/

    }
}
