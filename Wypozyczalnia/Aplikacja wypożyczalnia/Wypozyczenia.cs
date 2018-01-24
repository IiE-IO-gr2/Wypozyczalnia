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
        // Przycisk umożliwiający przejście do okna Pokaż Wypożyczenia
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokazWypozyczenia pw = new PokazWypozyczenia();
            pw.Show();
        }
        // Przycisk umożliwiający przejście do okna Dodaj Wypożyczenie
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajWypozyczenie dw = new DodajWypozyczenie();
            dw.Show();
        }
        // Przycisk umożliwiający przejście do okna Wyszukaj Wypożyczenie
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WyszukajWypozyczenie ww = new WyszukajWypozyczenie();
            ww.Show();
        }
        // Przycisk umożliwiający przejście do okna Usuń Wypożyczenie
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsunWypozyczenie uw = new UsunWypozyczenie();
            uw.Show();
        }
        // Przycisk umozliwiający przejście do okna Edytuj Wypożyczenie
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdytujWypozyczenie ew = new EdytujWypozyczenie();
            ew.Show();
        }
        // Przycisk umożliwiający powrót do menu po zalogowaniu
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }
    }
}
