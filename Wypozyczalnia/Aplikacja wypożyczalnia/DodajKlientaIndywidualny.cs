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
    public partial class DodajKlientaIndywidualny : Form
    {
        public DodajKlientaIndywidualny()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RodzajKlienta rk = new RodzajKlienta();
            rk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Pobranie danych z TextBoxów
            int id = int.Parse(textBox1.Text);
            string imie = textBox2.Text;
            string nazw = textBox3.Text;
            string nr = textBox4.Text;
            string psl = textBox5.Text;
            bool pl = false;
            if (textBox6.Text == "K")
                pl = true;
            string tl = textBox7.Text;
            string ad = textBox8.Text;
            string em = textBox9.Text;
            double pr = double.Parse(textBox10.Text);
            int ak = int.Parse(textBox11.Text);

            /// Stworzenie obiektów reprezentujących podane dane
            Klient klient1 = new Klient(id, tl, ad, em, pr, ak);
            Klient_indywidualny klientIndywidualny1 =
                new Klient_indywidualny(imie, nazw, nr, psl, pl);

            string exmsg_kl = klient1.DodajKlientaDoBazy();
            string exmsg_ind = klientIndywidualny1.DodajKlientaIndywidualnegoDoBazy(klient1.Id_klienta);
            if (string.IsNullOrWhiteSpace(exmsg_kl))
                MessageBox.Show("Dodano klienta do bazy");
            else
                MessageBox.Show("Wystąpił błąd:\n"+ exmsg_kl);
            if (string.IsNullOrWhiteSpace(exmsg_ind))
                MessageBox.Show("Dodano połączenie oraz klienta indywidualnego do bazy");
            else
                MessageBox.Show("Wystąpił błąd:\n" + exmsg_ind);
        }

        private void DodajKlientaIndywidualny_Load(object sender, EventArgs e)
        {

        }
    }
}
