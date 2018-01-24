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
        private void WybierzKlienta_Load(object sender, EventArgs e)
        {
            string zapytanie = @"select k.[Id_klienta],k.[Telefon_kontaktowy],k.[Adres],k.[Adres_email],k.[Promocja],k.[Aktywnosc], ki.[Imię],ki.[Nazwisko],ki.[PESEL]" +
                @"from [dbo].[Klient] as k inner join [dbo].[Klient_indywidualny] as ki on k.[Id_klienta] = ki.[Id_klienta]";
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
                MessageBox.Show("ID wybranego klienta " + id);
                pobraneIDKlienta.Text = id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano klienta");
            }
        }
        public string pobraneIDKlientaWartosc
        {
            get { return pobraneIDKlienta.Text; }
        }
    }
}

  
