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
    public partial class Wypozyczenia : Form
    {
        public Wypozyczenia()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Przycisk umożliwiający przejście do okna Pokaż Wypożyczenia
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokazWypozyczenia pw = new PokazWypozyczenia();
            pw.Show();
        }
        /// <summary>
        ///Przycisk umożliwiający przejście do okna Dodaj Wypożyczenie
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajWypozyczenie dw = new DodajWypozyczenie();
            dw.Show();
        }
        /// <summary>
        ///Przycisk umożliwiający przejście do okna Wyszukaj Wypożyczenie
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WyszukajWypozyczenie ww = new WyszukajWypozyczenie();
            ww.Show();
        }
        /// <summary>
        ///Przycisk umożliwiający przejście do okna Rozlicz Wypożyczenie
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RozliczWypozyczenie uw = new RozliczWypozyczenie();
            uw.Show();
        }
        /// <summary>
        ///Przycisk umożliwiający powrót do menu po zalogowaniu
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }
    }
}
