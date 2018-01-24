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
    public partial class PokazWypozyczenia : Form
    {
        public PokazWypozyczenia()
        {
            InitializeComponent();
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }

        private void PokazWypozyczenia_Load(object sender, EventArgs e)
        {

            string zapytanie = @"select [ID_wypożyczenia],[Data_wypożyczenia],[Data_planowanego_zwrotu],[Cena_za_wypozyczenie],[CzyUsuniete]" +
                @"from [dbo].[Wypożyczenie]";
       
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

    }
    
}
