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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Rezerwacja_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dodaj_rezerwacje dr = new Dodaj_rezerwacje();
            dr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_po_zalogowaniu mpz = new Menu_po_zalogowaniu();
            mpz.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usun_rezerwacje ur = new Usun_rezerwacje();
            ur.Show();
        }
    }
}
