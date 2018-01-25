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
    public partial class WybierzSamochRezerwacje : Form
    {
        public WybierzSamochRezerwacje()
        {
            InitializeComponent();
        }

        private void WybierzSamochRezerwacje_Load(object sender, EventArgs e)
        {
            string zapytanie = @"select [Id_samochodu],[Marka],[Model],[Cena_za_dobę],[Kaucja],[Pojemnosc],[Rodzaj_paliwa],[Rocznik],[Kolor]" +
                @"from [dbo].[Samochód] WHERE (([CzyUsuniete] = 0 or [CzyUsuniete] is null) and Dostepnosc = 1)";
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
        ///Przycisk umożliwiający zatwierdzenie wybranego samochodu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                string id = dr.ItemArray[0].ToString();
                PobraneIDSam.Text = id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano samochodu");
            }
        }

        public string PobraneIDSamWartosc
        {
            get { return PobraneIDSam.Text; }
        }
    }
}