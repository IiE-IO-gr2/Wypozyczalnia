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
    public partial class PokazWypozyczenia : Form
    {
        public PokazWypozyczenia()
        {
            InitializeComponent();
        }
        //Przycisk umożliwiający przejście do poprzedniego okna
        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }
        //Przycisk umożliwiający uzupełnienie tabeli aktualną listą wypożyczeń
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DataTable();
            string exmsg = "";
            DataTable dt = Wypożyczenie.PokazWypozyczenie(ref exmsg);
            if (!string.IsNullOrWhiteSpace(exmsg))
               {
                 MessageBox.Show("Wystąpił błąd: " + exmsg);
               }
            else
               {
                 dataGridView1.DataSource = dt;
               }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
