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
    public partial class PokazKlientow : Form
    {
        public PokazKlientow()
        {
            InitializeComponent();

        }
        /// <summary>
        /// metoda która wprowadza do listy wszystkich klientów
        /// </summary>
        private void PokazKlientow_Load(object sender, EventArgs e)
        {
            string zapytanie = @"select k.Id_klienta, k.Adres, k.Adres_email, k.Telefon_kontaktowy, kf.Nazwa_firmy, " +
                @"kf.NIP, ki.Imię, ki.Nazwisko, ki.PESEL from ([dbo].[Klient] as k left join [dbo].[Klient_firmy] as kf " +
                @"on k.Id_klienta = kf.Id_klienta) left join [dbo].[Klient_indywidualny] as ki on k.Id_klienta = ki.Id_klienta" +
                @"  where k.CzyUsuniete is null or k.CzyUsuniete = 0";
            string exmsg = "";
            DataTable dt = FunkcjePomicnicze.PobierzDaneSQL(zapytanie, ref exmsg);
            if (!string.IsNullOrWhiteSpace(exmsg))
            {
                MessageBox.Show("Wystąpił błąd: " + exmsg);
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Select();
            }
        }
        /// <summary>
        /// Przycisk umożliwiający powrót do formularza Klienci
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci k = new Klienci();
            k.Show();
        }
    }
}
