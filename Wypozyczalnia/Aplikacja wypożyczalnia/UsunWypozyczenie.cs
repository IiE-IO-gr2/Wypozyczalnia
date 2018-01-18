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
    public partial class UsunWypozyczenie : Form
    {
        public UsunWypozyczenie()
        {
            InitializeComponent();
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia w = new Wypozyczenia();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
