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
    public partial class PokazRezerwacje : Form
    {
        public PokazRezerwacje()
        {
            InitializeComponent();
        }

        /// <summary>
        ///Przycisk, który cofa do sekcji Samochody
        /// </summary>
        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacje re = new Rezerwacje();
            re.Show();
        }

        ///<summary>
        ///Przycisk button1 jest odpowiedzialny za uaktualnienie(pobranie) listy wypożyczeń z bazy danych
        /// i umieszczenie ich w tabeli(dataGridView1)
        ///</summary>
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DataTable();
            string exmsg = "";
            DataTable dt = Rezerwacja.PokazRezerwacje(ref exmsg);
            if (!string.IsNullOrWhiteSpace(exmsg))
            {
                MessageBox.Show("Wystąpił błąd: " + exmsg);
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
