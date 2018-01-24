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
    public partial class WybierzKlientaIndywidualnego : Form
    {
        public WybierzKlientaIndywidualnego()
        {
            InitializeComponent();
        }
        private void WybierzKlientaIndywidualnego_Load(object sender, EventArgs e)
        {
            string zapytanie = @"select k.[Id_klienta],k.[Telefon_kontaktowy],k.[Adres],k.[Adres_email],k.[Promocja],k.[Aktywnosc], ki.[Imię],ki.[Nazwisko],ki.[PESEL]" +
                @"from [dbo].[Klient] as k inner join [dbo].[Klient_indywidualny] as ki on k.[Id_klienta] = ki.[Id_klienta] WHERE (k.[CzyUsuniete] = 0 or k.[CzyUsuniete] is null)";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                string id = dr.ItemArray[0].ToString();
                string exmsg_czymoze = "";
                string zapytanie_czymoze = @"select count(*) from Wypożyczenie where ((CzyRozliczone=0 or CzyRozliczone is null)" +
                    @"and [Id_Klienta] = " + id + ")";
                int ileWypozyczenNierozliczonych = int.Parse(FunkcjePomicnicze.PobierzDaneSQLPojedyncze(zapytanie_czymoze, ref exmsg_czymoze));
                if (!string.IsNullOrWhiteSpace(exmsg_czymoze))
                {
                    MessageBox.Show("Wystapił błąd podczas sprawdzania, czy dany klient może dokonać kolejnego wypozyczenia.\n\t-" + exmsg_czymoze);
                }
                else if (ileWypozyczenNierozliczonych > 0)
                {
                    MessageBox.Show("Dany klient nie może dokonać kolejnego wypożyczenia");
                }
                else
                {
                    pobraneIDKlienta.Text = id;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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

  
