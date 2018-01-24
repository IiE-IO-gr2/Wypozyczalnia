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
    public partial class PokazSamochody : Form
    {
        public PokazSamochody()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Przycisk, który cofa do sekcji Samochody
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody w = new Samochody();
            w.Show();
        }
        /// <summary>
        ///Przycisk, który aktualizuje i pokazuje listę wszystkich samochodów w bazie
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DataTable();
            string exmsg = "";
            DataTable dt = Samochód.PokazSamochody(ref exmsg);
            if (!string.IsNullOrWhiteSpace(exmsg))
            {
                MessageBox.Show("Wystąpił błąd: " + exmsg);
            }
            else
            {
                dataGridView1.DataSource = dt;
            }

        }
            private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void PokazSamochody_Load(object sender, EventArgs e)
        {

        }
    }
}
