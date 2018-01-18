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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokazWypozyczenia pw = new PokazWypozyczenia();
            pw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajWypozyczenie dw = new DodajWypozyczenie();
            dw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WyszukajWypozyczenie ww = new WyszukajWypozyczenie();
            ww.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsunWypozyczenie uw = new UsunWypozyczenie();
            uw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdytujWypozyczenie ew = new EdytujWypozyczenie();
            ew.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }
    }
}
