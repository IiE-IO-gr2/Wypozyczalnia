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
    public partial class EdytujSamochód : Form
    {
        public EdytujSamochód()
        {
            InitializeComponent();
        }

        private void WsteczES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody es = new Samochody();
            es.Show();
        }

        private void ZatwierdźES_Click(object sender, EventArgs e)
        {

        }
    }
}
