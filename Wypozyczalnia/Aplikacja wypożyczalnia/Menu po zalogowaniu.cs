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

        /// <summary>
        /// Przycisk umożliwiający wylogowanie się z systemu i powrót do panelu logowania się
        /// </summary>
        private void wylogowanie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wylogowano");
            this.Hide();
            Panel_administratora pan = new Panel_administratora();
            pan.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Samochodów
        /// </summary>
        private void samochody_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody sa = new Samochody();
            sa.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Rezerwacji
        /// </summary>
        private void rezerwacje_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacje rez = new Rezerwacje();
            rez.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Klienci
        /// </summary>
        private void klienci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci kl = new Klienci();
            kl.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający przejście do formularza Wypożyczeń
        /// </summary>
        private void wypozyczenia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }

        /// <summary>
        /// Przycisk umożliwiający wysyłanie maili przypominających o rezerwacji
        /// </summary>
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

        /// <summary>
        /// Przycisk umożliwiający wysyłanie maili przypominających o zapłacie
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            string exmsg = "";
            string tytulMaila = "Przypomnienie o zapłacie";
            string trescMaila = "Dzień dobry." +
                "Pragniemy przypomnieć o konieczności dokonania zapłaty za wypożyczenie samochodu." +
                "Termin płatności mija za 5 dni roboczych. Prosimy o jak najszybsze uregulowanie rachunku." +
                "Mamy nadzieję, że jest Pan/Pani zadowolona z naszej współpracy oraz w przyszłości chętnie Pan/Pani do nas wróci." +
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

        /// <summary>
        /// Przycisk umożliwiający wysyłanie maili informujących o opóźnieniach samochodu
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            string exmsg = "";
            string tytulMaila = "Opóźnienia w zwrocie";
            string trescMaila = "Dzień dobry." +
                "Z przykrością informujemy, że zarezerwowany przez Pana/Panią samochód będzie dostępny w opóźnionym terminie." +
                "Przepraszamy za wszelkie niedogodności. Postaramy się jak najszybciej udostępnić Panu/Pani samochód." +
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

        /// <summary>
        /// Przycisk umożliwiający wysyłanie maili przypominających o wpłacie zaliczki
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            string exmsg = "";
            string tytulMaila = "Przypomnienie o wpłacie zaliczki";
            string trescMaila = "Dzień dobry." +
                "Przypominamy o konieczności wpłaty zaliczki za dokonaną przez Pana/Panią rezerwację w naszym systemie." +
                "Należy dokonać płatności w ciągu 24h od momentu złożenia rezerwacji." +
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
