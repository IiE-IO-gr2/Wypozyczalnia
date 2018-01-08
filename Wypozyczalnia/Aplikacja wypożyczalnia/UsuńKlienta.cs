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
    public partial class UsuńKlienta : Form
    {
        public UsuńKlienta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci k = new Klienci();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usunięto klienta z bazy");
            this.Hide();
            UsuńKlienta uk = new UsuńKlienta();
            uk.Show();
        }
    }
}
