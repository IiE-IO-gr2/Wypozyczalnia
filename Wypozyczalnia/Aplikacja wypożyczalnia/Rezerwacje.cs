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
    public partial class Rezerwacje : Form
    {
        public Rezerwacje()
        {
            InitializeComponent();
        }

        /// <summary>
        ///Przycisk umożliwiający przejście do okna Dodaj Rezerwacje
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dodaj_rezerwacje dr = new Dodaj_rezerwacje();
            dr.Show();
        
        }

        /// <summary>
        ///Przycisk umożliwiający przejście do okna Usuń Rezerwacje
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usun_rezerwacje ur = new Usun_rezerwacje();
            ur.Show();
        }

        /// <summary>
        ///Przycisk umożliwiający przejście do okna Pokaż Rezerwacje
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokazRezerwacje pr = new PokazRezerwacje();
            pr.Show();
      
        }

        /// <summary>
        ///Przycisk umożliwiający przejście do okna Wyszukaj Rezerwacje
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wyszukaj_rezerwacje wr = new Wyszukaj_rezerwacje();
            wr.Show();
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
