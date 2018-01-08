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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            RodzajKlienta rk = new RodzajKlienta();
            rk.Show();
          
        }

        private void usun_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsuńKlienta uk = new UsuńKlienta();
            uk.Show();

        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            WyszukajKlienta wk = new WyszukajKlienta();
            wk.Show();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdytujKlienta ek = new EdytujKlienta();
            ek.Show();

        }
    }
}
