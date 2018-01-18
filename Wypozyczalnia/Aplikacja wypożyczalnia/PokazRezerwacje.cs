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
    public partial class PokazRezerwacje : Form
    {
        public PokazRezerwacje()
        {
            InitializeComponent();
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezerwacja re = new Rezerwacja();
            re.Show();

        }
    }
}
