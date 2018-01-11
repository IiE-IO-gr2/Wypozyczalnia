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
    public partial class Rezerwacja : Form
    {
        public Rezerwacja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dodaj_rezerwacje dr = new Dodaj_rezerwacje();
            dr.Show();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usun_rezerwacje ur = new Usun_rezerwacje();
            ur.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokazRezerwacje pr = new PokazRezerwacje();
            pr.Show();
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wyszukaj_rezerwacje wr = new Wyszukaj_rezerwacje();
            wr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edytuj_rezerwacje er = new Edytuj_rezerwacje();
            er.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }
    }
}
