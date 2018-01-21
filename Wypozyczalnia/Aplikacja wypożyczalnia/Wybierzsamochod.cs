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
using Aplikacja_wypożyczalnia;

namespace Aplikacja_wypożyczalnia
{
    public partial class Wybierzsamochod : Form
    {
        string nazwa;
        public Wybierzsamochod()
        {
            
            InitializeComponent();
            System.Data.DataTable exmsg_kl = FunkcjePomicnicze.PobierzDaneSQL("SELECT * FROM  Klient_firmy", ref nazwa);
           // Klient_firmy klientwyswietl = new Klient_firmy(nazwa, nip);
           //dataGridView1.Rows.Add(id, nazwa, nip, tl);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajWypozyczenie dw = new DodajWypozyczenie();
            dw.Show();
        }
    }
}
