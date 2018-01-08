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
    public partial class WyszukajSamochód : Form
    {
        public WyszukajSamochód()
        {
            InitializeComponent();
        }

        private void WsteczWS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody ws = new Samochody();
            ws.Show();
        }
    }
}
