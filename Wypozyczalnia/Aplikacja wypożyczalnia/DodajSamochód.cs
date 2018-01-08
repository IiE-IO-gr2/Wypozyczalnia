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
    public partial class DodajSamochód : Form
    {
        public DodajSamochód()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WsteczDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody ds = new Samochody();
            ds.Show();
        }

        private void ZatwierdźDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodano samochód");
            this.Hide();
            DodajSamochód dod = new DodajSamochód();
            dod.Show();
        }

        private void Inne_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
