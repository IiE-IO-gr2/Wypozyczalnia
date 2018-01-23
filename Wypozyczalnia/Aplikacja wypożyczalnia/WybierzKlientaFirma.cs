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
    public partial class WybierzKlientaFirma : Form
    {
        public WybierzKlientaFirma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WybierzKlienta wk = new WybierzKlienta();
            wk.Show();
        }
    }
}
