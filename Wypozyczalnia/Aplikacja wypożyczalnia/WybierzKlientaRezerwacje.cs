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
    public partial class WybierzKlientaRezerwacje : Form
    {
        public WybierzKlientaRezerwacje()
        {
            InitializeComponent();
        }

        private void WybierzKlientaRezerwacje_Load(object sender, EventArgs e)
        {
            string zapytanie = @"select k.[Id_klienta],k.[Telefon_kontaktowy],k.[Adres],k.[Adres_email],k.[Promocja],k.[Aktywnosc], ki.[Nazwa_firmy], ki.[NIP]" +
                @"from [dbo].[Klient] as k inner join [dbo].[Klient_firmy] as ki on k.[Id_klienta] = ki.[Id_klienta] WHERE (k.[CzyUsuniete] = 0 or k.[CzyUsuniete] is null)";
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
        /// Przycisk umożliwiający zatwierdzenie wyboru klienta z bazy
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                string id = dr.ItemArray[0].ToString();
                pobraneIDKlienta.Text = id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano klienta");
            }
        }

        public string PobraneIDKlientaWartosc
        {
            get { return pobraneIDKlienta.Text; }
        }
    }
}