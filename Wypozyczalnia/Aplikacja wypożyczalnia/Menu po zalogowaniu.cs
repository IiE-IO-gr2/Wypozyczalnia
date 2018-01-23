using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.Mail;

namespace Aplikacja_wypożyczalnia
{
 


    public partial class Menu_po_zalogowaniu : Form
    {

        public Menu_po_zalogowaniu()
        {
            InitializeComponent();
        }

        private void Menu_po_zalogowaniu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            data.Text = DateTime.Now.ToLongDateString();
            czas.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czas.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void wylogowanie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wylogowano");
            this.Hide();
            Panel_administratora pan = new Panel_administratora();
            pan.Show();
        }

        private void samochody_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody sa = new Samochody();
            sa.Show();
        }

        private void rezerwacje_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacja rez = new Rezerwacja();
            rez.Show();
        }

        private void klienci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci kl = new Klienci();
            kl.Show();
        }

        private void wypozyczenia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exmsg = "";
            string tytulMaila = "Przypomnienie o rezerwacji";
            string trescMaila = "Dzień dobry." +
                "Pragniemy przypomnieć o złożonej przez Pana/Panią rezerwacji u numerze 4127." +
                "Samochód będzie dostępny do Pana/Pani potrzeb przez 3 doby." +
                "Mamy nadzieję, że pojazd się przysłuży oraz w przyszłości chętnie Pan/Pani do nas wróci." +
                "Serdecznie pozdrawiamy," +
                "Biuro Obsługi Wypożyczalni KGB";
            List<string> listaAdresatow = new List<string>();
            listaAdresatow.Add("iie.io.gr2@gmail.com");
            listaAdresatow.Add("mateuszsobol25@gmail.com");
            FunkcjePomicnicze.WyslijMaila(tytulMaila, trescMaila, listaAdresatow, ref exmsg);
            if (string.IsNullOrWhiteSpace(exmsg))
                MessageBox.Show("Wysylanie powiodlo sie.");
            else
                MessageBox.Show("Wysylanie nie powiodlo sie.");
        }
    }
}
